using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectLab
{
    class Hotel
    {
        public Hotel(string name)
        {
            Name = name;
            Rooms = new Room[0];
        }

        public string Name { get; set; }
        public Room[] Rooms;

        public void AddRoom(Room room)
        {
            Array.Resize(ref Rooms, Rooms.Length + 1);
            Rooms[^1] = room;
            Console.WriteLine("Room added");
        }

        public bool HasRoom()
        {
            return Rooms.Length > 0;
        }
        public void MakeReservation(int roomId)
        {
            foreach (Room room in Rooms)
            {
                if (room.Id == roomId)
                {
                    if (room.IsAviable)
                    {
                        room.IsAviable = false;
                        Console.WriteLine("Reserved!");
                    }
                    else
                        Console.WriteLine("Room is Full!");
                }
            }
        }

    }
}
