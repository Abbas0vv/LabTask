using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ObjectLab.Models
{
    public class User : Human
    {
        string _username;
        string _password;
        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                if (value.Length > 5 && value.Length < 26)
                {
                    _username = value;
                }
            }
        }
        public string Password {
            get
            {
                return _password;
            }
            set 
            {
                if (value.Length > 9 && value.Length < 26)
                {
                    _password = value;
                }
            } 
        }

        public User( string password , string username)
        {
            Password = password;
            Username = username;
        }
        public User(string name, string surname, byte age, string password, string username) : base(name, surname, age)
        {
            Password = password;
            Username = username;
            //Username = name + " " + surname;
        }
    }
}
