using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectLab.Exeptions;

namespace ObjectLab.Models
{
    public class Hotel
    {
        static int _id;

        public Hotel(string name)
        {
            Id = _id;
            Name = name;
            _id++;
            Rooms = new List<Room>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        private List<Room> Rooms;

        public void AddRoom(Room room)
        {
            Rooms.Add(room);
        }
        public List<Room> FindAllRoom(decimal price)
        {
            List<Room> filteredRooms = new List<Room>();
            foreach (Room room in Rooms)
            {
                if (room.Price == price)
                {
                    filteredRooms.Add(room);
                }
            }
            return filteredRooms;
        }
        public List<Room> GetAll()
        {
            return Rooms;
        }
        public void MakeReservation(int? id, int countOfCostumers)
        {
            if (id == null)
                throw new NullReferenceException("id");

            foreach (var room in Rooms)
            {
                if (room.Id == id && room.PersonCapacity >= countOfCostumers)
                {
                    if (room.IsAviable)
                        room.IsAviable = false;
                    else
                        throw new NotAvailableException();
                }
                else
                    throw new SomethingWentWrongException();
            }

        }
    }
}
