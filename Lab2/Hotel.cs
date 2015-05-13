﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Hotel
    {
        public string name;
        public string description;
        public string address;
        public int stars;
        public double distanceToCenter;
        public DateTime openingDate;
        public Room[] rooms;

        public Hotel(string name, string description, string address, int stars, double distanceToCenter, DateTime openingDate, Room[] rooms){
            this.name = name;
            this.description = description;
            this.address = address;
            this.stars = stars;
            this.distanceToCenter = distanceToCenter;
            this.openingDate = openingDate;
            this.rooms = rooms;
        }

        public void displayInfo()
        {
            Console.WriteLine("\n____________");
            Console.WriteLine("Hotel Info:");
            Console.WriteLine("name: {0}", name);
            Console.WriteLine("description: {0}", description);
            Console.WriteLine("address: {0}", address);
            Console.WriteLine("stars: {0}", stars);
            Console.WriteLine("distanceToCenter: {0}", distanceToCenter);
            Console.WriteLine("opening date: {0}", openingDate);
            Console.WriteLine("rooms: ");
            foreach (Room r in rooms)
                r.displayInfo();
        }
    }
}
