using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {


        
        static void Main(string[] args)
        {
            /*Hotel h = new Hotel();
            h.name = "Unirea";
            h.description = "Visit our hotel!";
            h.address = "Piata Unirii";
            h.distanceToCenter = 1.2;
            h.openingDate = DateTime.Now;
            h.stars = 5;
            Room[] hotelRooms = new Room[2];
            Room room1 = new Room();
            room1.floor = 4;
            room1.description = "room1 desc";
            room1.places = 5;
            room1.type = RoomTypes.Single;

            Room room2 = new Room();
            room2.type = RoomTypes.Double;
            room2.floor = 3;
            room2.description = "room2 desc";
            room2.places = 4;

            hotelRooms[0] = room1;
            hotelRooms[1] = room2;
            h.rooms = hotelRooms;

            Console.WriteLine("name = {0}", h.name);
            Console.WriteLine("address = {0}", h.address);
            Console.WriteLine("year = {0}", h.openingDate.Year);
            Console.WriteLine("no. of rooms: {0}", h.rooms.Length);
            
            h.displayInfo();
*/
            Room[] myRooms = new Room[2];
            Room room1 = new Room("room1 description", 3, 5, RoomTypes.Single);
            Room room2 = new Room("room2 description", 4, 7, RoomTypes.Double);
            myRooms[0] = room1;
            myRooms[1] = room2;
            Hotel h = new Hotel("Unirea", "Unirea description!", "Piata Unirii", 4, 1.2, DateTime.Now, myRooms);
            h.displayInfo();


            Hotel h1 = new Hotel("Astoria", "Astoria desc", "Piata Unirii", 3, 100, DateTime.Now, myRooms);
            h1.setDistanceMeasurementUnit("km");
            string newDist = h1.getDistanceMeasurementUnit();
            Console.Write(newDist);
            h.displayInfo();
            h1.displayInfo();

            string type = "km";
            h1.setDistanceMeasurementUnit(type);
            
            Console.WriteLine("________");
            double newDist2 = h1.getKmOrMiles(type);
            Console.WriteLine(newDist2);
            Console.ReadLine();


        }
    }
}
