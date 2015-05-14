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
        private string description;
        private int places;
        private int floor;
       private RoomTypes type;
        private int number;


        private string Description
        {
            get { return description; }
            set { if(value.Length> 500)
                Console.WriteLine("description length > 500!");
                else
                description = value;
            }
        }

        private RoomTypes Type
        {
            get;
            set;
        }
        private int Number{
            get { return number; }
            set
            {
                if (value > 10000 || value < 0)
                    Console.WriteLine("number not in interval!");
                else number = value;
            }
        }

        private int Floor
        {
            get { return floor; }
            set
            {
                if (value > 1000 || value < 0)
                    Console.WriteLine("floor not in interval!");
                else floor = value;
            }
        }

        public Room(string description, int places, int floor, RoomTypes type, int number)
        {
            this.Description = description;
            this.places = places;
            this.Floor = floor;
            this.Type = type;
            this.Number = number;
        }


        public void displayInfo()
        {
            Console.WriteLine("\n____________");
            Console.WriteLine("Room Info:");
            Console.WriteLine("description: {0}", Description);
            Console.WriteLine("places: {0}", places);
            Console.WriteLine("floor: {0}", Floor);
            Console.WriteLine("type: {0}", Type);
        }
    }
}
