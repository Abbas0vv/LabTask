
using ObjectLab.Models;

namespace ObjectLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Plz enter your username : ");
            string userName = Console.ReadLine();
            Console.Write("Plz enter your password : ");
            string password = Console.ReadLine();

            User user = new User(userName, password);
        }
    }
}
