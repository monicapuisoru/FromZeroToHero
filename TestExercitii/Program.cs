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
        public enum DiscountTypes { General, Promotion, BestDeal };

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
                priceWithDisc = price - 25.0 / 100.0 * price;
            else if (age <= 14 && age >= 7)
                priceWithDisc = price - 15.0 / 100.0 * price;
            else 
                priceWithDisc = price - 5.0 / 100.0 * price;
        }

        static void printPrice2(ref double price, int age)
        {
            if (age < 7)
                price = price - 25.0 / 100.0 * price;
            else if (age <= 14 && age >= 7)
                price = price - 15.0 / 100.0 * price;
            else
                price = price - 5.0 / 100.0 * price;
        }

        static double extraDiscount(double price, int age  = 14, DiscountTypes tip = DiscountTypes.Promotion)
        {
            double newPrice = price;
            if (age < 7)
                newPrice = price - 25.0 / 100.0 * price;
            else if (age <= 14 && age >= 7)
                newPrice = price - 15.0 / 100.0 * price;
            else
                newPrice = price - 5.0 / 100.0 * price;

            switch (tip)
            {
                case DiscountTypes.BestDeal:
                    newPrice = price - 50.0 / 100.0 * price;
                    break;
               
                case DiscountTypes.Promotion:
                    newPrice = price - 25.0 / 100.0 * price;
                    break;
                default:
                    break;
            }
            return newPrice;
        }

        static double extraDiscount(int price, int age = 14, DiscountTypes tip = DiscountTypes.Promotion)
        {
            double newPrice = (double)price;
            if (age < 7)
                newPrice = (double)price - 25.0 / 100.0 * (double)price;
            else if (age <= 14 && age >= 7)
                newPrice = (double)price - 15.0 / 100.0 * (double)price;
            else
                newPrice = (double)price - 5.0 / 100.0 * (double)price;

            switch (tip)
            {
                case DiscountTypes.BestDeal:
                    newPrice = (double)price - 50.0 / 100.0 * (double)price;
                    break;

                case DiscountTypes.Promotion:
                    newPrice = (double)price - 25.0 / 100.0 * (double)price;
                    break;
                default:
                    break;
            }
            return newPrice;
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
           
            double price = 98.0;
            int age = 5;
            //double priceWithDisc;
           // printPrice(price, age, out priceWithDisc);
            Console.WriteLine(price);
            printPrice2(ref price, age);
          //  Console.WriteLine(priceWithDisc);
          //  Console.WriteLine(price);
           // Console.ReadLine();
            double rez;
            //rez = extraDiscount(price, 5, DiscountTypes.Promotion);
           // Console.WriteLine(rez);

            rez = extraDiscount(price);
            Console.WriteLine(rez);
            rez = extraDiscount(price, tip : DiscountTypes.Promotion);
            Console.WriteLine(rez);
            rez = extraDiscount(price, tip: DiscountTypes.Promotion, age : 5);
           Console.WriteLine(rez);
            rez = extraDiscount(100, 5, DiscountTypes.Promotion);


            Console.WriteLine("rez overload:  " + rez);
          * 
          *  */


            Console.ReadLine();
        }
    }
}
