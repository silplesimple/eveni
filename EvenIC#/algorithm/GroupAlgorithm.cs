using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithm
{
    internal class GroupAlgorithm
    {
        class Record
        {
            public string Name { get; set; }
            public int Quantity { get; set; }
        }

        static void Main()
        {
            List<Record> GetAll()
            {
                return new List<Record>
                {
                    new Record{Name="RADIO",Quantity=3 },
                    new Record{Name="TV",Quantity=1},
                    new Record{Name="RADIO",Quantity=2 },
                    new Record{Name="DVD",Quantity=4 }

                };
            }

            void PrintData(string message,List<Record> data)
            {
                Console.WriteLine(message);
                foreach(var item in data)
                {
                    Console.WriteLine($"{item.Name,5}-{item.Quantity}");
                }
            }

            List<Record> records = GetAll();
            List<Record> groupsS = new List<Record>();
            int N = records.Count;

            for(int i=0;i<N-1;i++)
            {
                for(int j=i+1;j<N;j++)
                {
                    if (String.Compare(records[i].Name, records[j].Name)>0)
                    {
                        var t = records[i];
                        records[i] = records[j];
                        records[j] = t;
                    }
                }
            }

            int subtotal = 0;
            for(int i=0;i<N;i++)
            {
                subtotal += records[i].Quantity;
                if((i+1)==N||
                    records[i].Name != records[i+1].Name)
                {
                    groupsS.Add(new Record
                    {
                        Name = records[i].Name,
                        Quantity = subtotal
                    });

                    subtotal = 0;
                }

            }

            PrintData("[1] 정렬된 원본 데이터:", records);
            PrintData("[2] 이름으로 그룹화 된 데이터", groupsS);
            PrintData("[3] LINQ로 그룹화 된 데이터:", records.
                GroupBy(r => r.Name).Select(g => new Record
                {
                    Name = g.Key, Quantity = g.Sum(n => n.Quantity)
                }).ToList());
        }
    }
}
