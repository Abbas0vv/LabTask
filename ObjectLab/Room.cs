using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectLab
{
    class Room
    {

        public Room(string name, double price, int personCapacity)
        {
            Id = _id;
            Name = name;
            Price = price;
            PersonCapacity = personCapacity;
            IsAviable = true;
            _id++;
        }
        public Room()
        {
            
        }

        static int _id;
        public int Id { get; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int PersonCapacity { get; set; }
        public bool IsAviable { get; set; } //Aviable (true) - NotAviable (false)

        public string ShowInfo()
        {
           return $"{Id}. {Name} Room's abiable status = {IsAviable}. Price is {Price}. The capacity of room is {PersonCapacity}";
        }

        public override string ToString()
        {
            return ShowInfo();
        }
    }
}
