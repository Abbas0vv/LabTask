using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectLab
{
    class User : Human
    {
        string userName;
        string password;

        public User(string name, string surname, string userName, string password) : base(name, surname)
        {
            UserName = userName;
            Password = password;
        }

        public string UserName
        {
            get { return userName; }

            set
            {
                if (value.Length >= 6 && value.Length <= 25)
                    userName = value;
                else
                    throw new Exception("Invalid User Nema");
            }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

    }
}
