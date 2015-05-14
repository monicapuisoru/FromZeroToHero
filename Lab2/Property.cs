using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Property
    {
        private string name;
        private string description;
        private string address;
        private int stars;
        private double distanceToCenter;
        static string distanceMeasurementUnit;
        private DateTime openingDate;

        private Boolean hasPool;
        private Boolean hasWiFi;

       // protected Room[] rooms;

        private string Name
        {
            get { return name; }
            set
            {
                if (value.Length > 50)
                    Console.WriteLine("name length > 50!");
                else
                    name = value;
            }
        }

        private string Description
        {
            get { return description;}
            set
            {
                if (value.Length > 500)
                    Console.WriteLine("description  length > 500!");
                else
                    description = value;
            }
        }

        private string Address
        {
            get { return address; }
            set
            {
                if (value.Length > 100)
                    Console.WriteLine("address length > 100!");
                else
                    address = value;
            }
        }

        private int Stars
        {
            get { return stars; }
            set {
                if (value < 0 || value > 50)
                    Console.WriteLine("stars not in interval!");
                else
                    stars = value; 
            }
        }

        private double DistanceToCenter
        {
            get { return distanceToCenter; }
            set
            {
                if (value < 0 || value > 100)
                    Console.WriteLine("distanceToCenter not in interval!");
                else
                    distanceToCenter = value;
            }
        }

        private DateTime OpeningDate
        {
            get { return openingDate; }
            set
            {
                DateTime d1 = new DateTime(1800, 1, 1);
                DateTime d2 = DateTime.Now;
                if (value < d1 || value > d2)
                    Console.WriteLine("openingDate not in interval!");
                else
                   openingDate = value;
            }
        }

        private Room[] Rooms
        {
            get;
            set;
        }

        public Boolean HasPool 
        { 
            get{return hasPool;}
            set{hasPool = value;}
        }

        public Boolean HasWiFi {
            get {  return hasWiFi; } 
            set {  hasWiFi = value; }
        }

        static Property()
        {
            distanceMeasurementUnit = "Miles";
        }

        public Property()
        {
            Description = description;
            Address = address;
            Name = name;
            Stars = stars;
            OpeningDate = openingDate;
            DistanceToCenter = distanceToCenter;
        }
        public Property(string name, string description, string address, int stars, double distanceToCenter,
            DateTime openingDate, Room[] rooms)
        {
            this.Name = name;
            this.Description = description;
            this.Address = address;
            this.Stars = stars;
            this.DistanceToCenter = distanceToCenter;
            this.OpeningDate = openingDate;
           // this.rooms = rooms;
            this.Rooms = rooms; 
        }

        public void setDistanceMeasurementUnit(string distanceMeasurementUnit2)
        {
            distanceMeasurementUnit = distanceMeasurementUnit2;
        }

       public string getDistanceMeasurementUnit()
       {
           return distanceMeasurementUnit;
       }

        public void displayInfo()
        {
            Console.WriteLine("\n____________");
            Console.WriteLine("Hotel Info:");
            Console.WriteLine("name: {0}", Name);
            Console.WriteLine("description: {0}", Description);
            Console.WriteLine("address: {0}", Address);
            Console.WriteLine("stars: {0}", Stars);
            Console.WriteLine("distanceToCenter: {0}", DistanceToCenter);
            Console.WriteLine("km or miles: {0}", distanceMeasurementUnit);
            Console.WriteLine("opening date: {0}", OpeningDate);
            Console.WriteLine("rooms: ");
            foreach (Room r in Rooms)
                r.displayInfo();
        }

        public double getKmOrMiles(string distanceType){
            DistanceConvertor d = new DistanceConvertor();
            if (distanceType.ToUpper().Equals("KM") && distanceMeasurementUnit.ToUpper().Equals("KM"))
                return distanceToCenter;
            else if (distanceType.ToUpper().Equals("KM") && distanceMeasurementUnit.ToUpper().Equals("MILES"))
                return d.convertMilesToKm(distanceToCenter);
            else if (distanceType.ToUpper().Equals("MILES") && distanceMeasurementUnit.ToUpper().Equals("MILES"))
                return distanceToCenter;
            else
                return d.convertKmToMiles(distanceToCenter);
        }
    }
}
