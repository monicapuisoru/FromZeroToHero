using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestExercitii
{
    class Program
    {

        static Boolean checkDate(DayOfWeek day)
        {
            string saturday = "saturday";
            string sunday = "sunday";
            string myDay = day.ToString();
            if ((myDay.ToUpper()).Equals(sunday.ToUpper()) || myDay.ToUpper().Equals(saturday.ToUpper()))
            {
                Console.WriteLine("true");
                Console.ReadLine();
                return true;
            }
            else {
                Console.WriteLine("false");
                Console.ReadLine();
                return false;
            }
        }

        static void Main(string[] args)
        {
             DateTime dt = new DateTime(2015, 5, 16);
             Boolean ans = checkDate(dt.DayOfWeek);
        }
    }
}
