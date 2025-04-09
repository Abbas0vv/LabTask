
using ObjectLab.Models;

namespace ObjectLab
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                bool flag = false;
                Console.WriteLine("Enter 1 for :Sistemə giriş:");
                Console.WriteLine("Enter 0 for :Çıxış:");
                Console.WriteLine();
                int userChoise = int.Parse(Console.ReadLine());
                switch (userChoise)
                {
                    case 1:
                        string name = Console.ReadLine();
                        decimal area = decimal.Parse(Console.ReadLine());
                        Planet ourPlanet = new Planet(name, area);
                        ourPlanet.CreateAndAddCountry();
                        Console.Clear();
                        while (!flag)
                        {
                            Console.WriteLine("Enter 1 for :Ölkə Yarat:");
                            Console.WriteLine("Enter 2 for :Bütün ölkələri gör:");
                            Console.WriteLine("Enter 3 for :Regiona görə ölkələri gör:");
                            Console.WriteLine("Enter 4 for :Ölkəni yenilə:");
                            Console.WriteLine("Enter 5 for :Ölkəni sil:");
                            Console.WriteLine("Enter 0 for :Əvvəlki menuya qayıt:");
                            Console.WriteLine();

                            userChoise = int.Parse(Console.ReadLine());

                            switch (userChoise)
                            {
                                case 1:
                                    ourPlanet.CreateAndAddCountry();
                                    break;
                                case 2:
                                    ourPlanet.GetAllCountries();
                                    break;
                                case 3:
                                    Console.WriteLine("Enter region code");
                                    int regionCode = 0;
                                    while (!int.TryParse(Console.ReadLine(), out regionCode))
                                    {
                                        Console.WriteLine("Enter correctly");
                                    }
                                    Region? regionName;
                                    switch (regionCode)
                                    {
                                        case 1:
                                            regionName = Region.Europe;
                                            break;
                                        case 2:
                                            regionName = Region.Asia;
                                            break;
                                        default:
                                            regionName = null;
                                            break;
                                    }
                                    ourPlanet.GetCountryByRegion(regionName);
                                    break;
                                case 4:
                                    Console.WriteLine("Enter new country name");
                                    string newCuntryName = Console.ReadLine();
                                    Console.WriteLine();
                                    Console.WriteLine("Enter new country area");
                                    decimal newArea = 0;
                                    while (!decimal.TryParse(Console.ReadLine(), out newArea))
                                    {
                                        Console.WriteLine("Enter correctly!");
                                    }
                                    Console.WriteLine();
                                    Console.WriteLine("Enter new country anthem");
                                    string newAnthem = Console.ReadLine();
                                    Console.WriteLine();
                                    Console.WriteLine("Enter new country region code");
                                    int NewRegionCode = 0;
                                    while (!int.TryParse(Console.ReadLine(), out NewRegionCode))
                                    {
                                        Console.WriteLine("Enter correctly");
                                    }
                                    Region? newRegionName;
                                    switch (NewRegionCode)
                                    {
                                        case 1:
                                            newRegionName = Region.Europe;
                                            break;
                                        case 2:
                                            newRegionName = Region.Asia;
                                            break;
                                        default:
                                            newRegionName = null;
                                            break;
                                    }
                                    Country newCountry = new Country(newCuntryName, newArea, newAnthem, newRegionName);
                                    Console.WriteLine();
                                    Console.WriteLine("Enter id");
                                    int id = int.Parse(Console.ReadLine());
                                    ourPlanet.UpdateCountry(id, newCountry);
                                    break;
                                case 5:
                                    break;
                                case 0:
                                    flag = true;
                                    break;
                                default:
                                    break;
                            }
                        }
                        break;
                    case 0:
                        return;
                    default:
                        break;
                }
            }
        }
    }
}
