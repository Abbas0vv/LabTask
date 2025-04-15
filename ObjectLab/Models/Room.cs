using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectLab.Models
{
    public class Room
    {
        static int _id;

        public Room(string name, decimal price, int personCapacity)
        {
            Id = _id;
            Name = name;
            Price = price;
            PersonCapacity = personCapacity;
            _id++;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int PersonCapacity { get; set; }
        public bool IsAviable { get; set; } = true;

        public override string ToString()
        {
            return ShowInfo();
        }
        public string ShowInfo()
        {
            return $"{Id}. Name = {Name}, Price = {Price}, IsAviable = {IsAviable}, PersonCapacity = {PersonCapacity}";
        }
    }
}
