using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Property
    {
        protected string name;
        protected string description;
        protected string address;
        protected int stars;
        protected double distanceToCenter;
        static string distanceMeasurementUnit;
        protected DateTime openingDate;

        protected Boolean hasPool;
        protected Boolean hasWiFi;
    

       // protected Room[] rooms;

        public string Name
        {
            get { return name; }
            set
            {
                if (value == null) name = "default name";
                else
                if (value.Length > 50)
                    Console.WriteLine("name length > 50!");
                else
                    name = value;
            }
        }

        public string Description
        {
            get { return description; }
            set
            {
                if (value == null) description = "default description";
                else  if (value.Length <= 500)
                {
                    description = value;
                }
                
            }
        }

        public string Address
        {
            get { return address; }
            set
            {
                if (value == null) address = "default addr";
                else
                if (value.Length > 100)
                    Console.WriteLine("address length > 100!");
                else
                    address = value;
            }
        }

        public int Stars
        {
            get { return stars; }
            set {
                if (value < 0 || value > 50)
                    Console.WriteLine("stars not in interval!");
                else
                    stars = value; 
            }
        }

        public double DistanceToCenter
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

        public DateTime OpeningDate
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

        public Room[] Rooms
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

        public virtual void displayInfo()
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

        public virtual double CalculateRating ()
        {
            return (double)2 * (double)stars;
        }


    }
}
