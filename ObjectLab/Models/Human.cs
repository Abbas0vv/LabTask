using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectLab.Models
{
    public class Human
    {
        public Human(string name, string surname, byte age)
        {
            Id = _id;
            Name = name;
            Surname = surname;
            Age = age;
            _id++;
        }
        public Human(string name) { Name = name; }
        public Human() { }

        string _name;
        static int _id;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public byte Age { get; set; }

        public void ShowFullData()
        {
            Console.WriteLine($"{Id}. {Name} {Surname} is {Age} years old.");
        }
        public string GetFullName()
        {
            return Name + " " + Surname;
        }
    }
}
