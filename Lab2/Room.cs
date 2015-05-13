using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public  enum RoomTypes
    {
        Single,
        Double,
        Twin,
        Duplex,
        KingBedroom
    }
    
    class Room
    {
        public string description;
        public int places;
        public int floor;
        public RoomTypes type;

        public Room(string description, int places, int floor, RoomTypes type)
        {
            this.description = description;
            this.places = places;
            this.floor = floor;
            this.type = type;
        }


        public void displayInfo()
        {
            Console.WriteLine("\n____________");
            Console.WriteLine("Room Info:");
            Console.WriteLine("description: {0}", description);
            Console.WriteLine("places: {0}", places);
            Console.WriteLine("floor: {0}", floor);
            Console.WriteLine("type: {0}", type);
        }
    }
}
