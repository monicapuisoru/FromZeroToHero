using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestExercitii
{
    class Program
    {
        public enum Seasons { summer, autumn, spring, winter };


        static Boolean checkDate(DayOfWeek day)
        {
            string saturday = "saturday";
            string sunday = "sunday";
            string myDay = day.ToString();
            if ((myDay.ToUpper()).Equals(sunday.ToUpper()) || myDay.ToUpper().Equals(saturday.ToUpper()))
            {
                Console.WriteLine("true");
                return true;
            }
            else {
                Console.WriteLine("false");
                Console.ReadLine();
                return false;
            }
        }


        static void printSeasons(Seasons mySeasons)
        {
          
            switch (mySeasons)
            { 
                case Seasons.summer:
                    Console.WriteLine("Summer!");
                    break;
               case Seasons.autumn:
                    Console.WriteLine("Autumn!");
                    break;
                case Seasons.winter:
                    Console.WriteLine("Winter!");
                    break;
                case Seasons.spring:
                    Console.WriteLine("Spring!");
                    break;
                default:
                    Console.WriteLine("Not a season!");
                    break;
            }
        }

        static string country(String[] countries)
        {
            int max = 0;
            String name = "";
            
            foreach(String country in countries)
            {
                int nr = country.Length;
                if (nr > max)
                {
                    max = nr;
                    name = country.ToString();
                }
            }
            return name;
        }

        static string countryParams(params String[] countries)
        {
            int max = 0;
            String name = "";

            foreach (String country in countries)
            {
                int nr = country.Length;
                if (nr > max)
                {
                    max = nr;
                    name = country.ToString();
                }
            }
            return name;
        }


        static void printPrice(double price, int age, out double priceWithDisc)
        {
            if (age < 7)
                priceWithDisc = price - 25 / 100 * price;
            else if (age <= 14 && age >= 7)
                priceWithDisc = price - 15 / 100 * price;
            else 
                priceWithDisc = price - 5 / 100 * price;

            
        }

        static void Main(string[] args)
        {/*
            DateTime dt = new DateTime(2015, 5, 16);
             Boolean ans = checkDate(dt.DayOfWeek);
            
            Seasons s = Seasons.spring;
            printSeasons(s);

            string[] countries = new string[] { "Romania", "England", "France", "United States of America" };
       
            String name = countryParams("Franta", "Romania", "Spania", "Italia", "Norvegia");
            Console.WriteLine(name);
            Console.ReadLine();
            */
            double price = 100.0;
            int age = 10;
            double priceWithDisc;
            printPrice(price, age, out priceWithDisc);
            Console.WriteLine(priceWithDisc);
            Console.ReadLine();
        }
    }
}
