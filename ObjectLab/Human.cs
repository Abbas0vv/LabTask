using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectLab
{
    class Human
    {
        public Human()
        {

        }
        public Human(string name)
        {
            Name = name;

        }
        public Human(string name, string surname)
        {
            Name = name;
            Surname = surname;

        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public byte Age { get; set; }


        public void ShowFullData()
        {
            Console.WriteLine($"Name : {Name} Surname : {Surname} Age : {Age}");
        }

        public string GetFullName()
        {
            return Name + " " + Surname;
        }
        
    }
}
