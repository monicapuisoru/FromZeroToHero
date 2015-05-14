using Lab2;
using System;

namespace FromZeroToHero.Excercices.Part3.Ex07
{
    class GuestHouse : Property
    {
        private string p1;
        private string p2;
        private string p3;
        private int p4;
        private double p5;
        private string p6;
        private DateTime dateTime;
        private bool p7;
        private bool p8;

        public int ComfortIndex { get; set; }
        public GuestHouse(string name, string description, string address, int stars,
                    double distanceToCenter, DateTime openingDate, Room[] rooms, int comfortIndex)
            : base(name, description, address, stars, distanceToCenter, openingDate, rooms)
        {
            ComfortIndex = comfortIndex;
        }

        public GuestHouse(string p1, string p2, string p3, int p4, double p5, string p6, DateTime dateTime, bool p7, bool p8)
        {
           
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
            this.p4 = p4;
            this.p5 = p5;
            this.p6 = p6;
            this.dateTime = dateTime;
            this.p7 = p7;
            this.p8 = p8;
        }
        
        public override double CalculateRating()
        {
           
                return ComfortIndex * 0.6 + 2 * stars * 0.4;
        }
    
    
    }
}
