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
        private Boolean hasAirConditioning;
        private Boolean hasFlatTV;

        #region Proprietati
        private string Description
        {
            get { return description; }
            set { if(value.Length> 500)
                Console.WriteLine("description length > 500!");
                else
                description = value;
            }
        }

  
        public RoomTypes Type
        {
            get { return type; }
            set
            {
                type = value;
                switch (value)
                {
                    case RoomTypes.Single:
                    case RoomTypes.Double:
                    case RoomTypes.Twin: places = 1; break;
                    case RoomTypes.KingBedroom:
                    case RoomTypes.Duplex: places = 2; break;
                }
            }
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
       
        public int Places
        {
            get { return places; }
            set
            {
                switch (Type)
                {
                    case RoomTypes.Single:
                        {
                            places = value == 1 ? value : 0;
                            break;
                        }
                    case RoomTypes.Double:
                    case RoomTypes.Twin:
                        {
                            places = value >= 1 && value <= 2 ? value : 0;
                            break;
                        }
                    case RoomTypes.KingBedroom:
                        {
                            places = value >= 2 && value <= 4 ? value : 0;
                            break;
                        }
                    case RoomTypes.Duplex:
                        {
                            places = value >= 2 && value <= 6 ? value : 0;
                            break;
                        }
                }
            }
        }

        public Boolean HasAirConditioning {
            get { return hasAirConditioning; }
            set { hasAirConditioning = value; } 
        }

        public Boolean HasFlatTV
        {
            get { return hasFlatTV; }
            set { hasFlatTV = value; }
        }

        #endregion



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
