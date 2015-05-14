using Lab2;
using System;

namespace FromZeroToHero.Excercices.Part3.Ex07
{
    class Hotel : Property
    {
        public int Likes { get; set; }
        public Hotel(string name, string description, string address, int stars,
                    double distanceToCenter, DateTime openingDate, Room[] rooms, int likes)
            : base(name, description, address, stars, distanceToCenter, openingDate, rooms)
        {
            Likes = likes;
        }

        public void update(string newAddr)
        {
            address = newAddr;
        }

        public override double CalculateRating()
        {
            if (Likes > 10000)
                return 10000 * 0.3 + 2 * stars * 0.7;
            else
                return Likes * 0.3 + 2 * stars * 0.7;
        }


        public override void displayInfo()
        {
            Console.WriteLine("\n____________");
            base.displayInfo();
            Console.WriteLine("Likes:{0}", Likes);

        }
    }
}
