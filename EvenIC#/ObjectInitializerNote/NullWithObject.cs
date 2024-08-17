using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectInitializerNote
{
    class PersonGirl
    {
        public string Name { get; set; }
        public Address address { get; set; }
    }
    class Address
    {
        public string Street { get; set; } = "알수 없음";
    }

    internal class NullWithObject
    {
        static void Main()
        {
            var people = new PersonGirl[] { new PersonGirl { Name = "RedPlus", address = new Address() { Street = "형이야" } }, null };

            ProcessPeople(people);

            void ProcessPeople(IEnumerable<PersonGirl> peopleArray)
            {
                foreach(var person in peopleArray)
                {
                    Console.WriteLine($"{person?.Name ?? "아무개"}은(는)" +
                        $"{person?.address?.Street ?? "아무곳"}에 삽니다.");
                }
            }

            var otherPeople = null as Person[];

            Console.WriteLine($"첫 번째 사람:{otherPeople?[0]?.Name??"없음"}");
        }
    }
}
