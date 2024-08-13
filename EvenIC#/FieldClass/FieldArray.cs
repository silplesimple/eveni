using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldClass
{
    class Schedule
    {
        private string[] weekDays = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
        public void PrintWeekDays()
        {
            foreach (var day in weekDays)
            {
                Console.Write($"{day}\t");
            }
            Console.WriteLine();
        }
    }

    internal class FieldArray
    {
        static void Main()
        {
            Schedule schedult = new Schedule();
            schedult.PrintWeekDays();
        }
    }
}
