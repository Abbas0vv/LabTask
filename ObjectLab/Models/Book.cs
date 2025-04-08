using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectLab.Models
{
    public class Book
    {
        static int _id;

        public Book(string name, string authorName, decimal price)
        {
            Id = _id;
            Name = name;
            AuthorName = authorName;
            Price = price;
            _id++;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public decimal Price { get; set; }
        
        public string ShowInfo()
        {
            return $"{Id}. {Name} from {AuthorName} is {Price}$";
        }

        public override string ToString()
        {
            return ShowInfo();
        }
    }
}
