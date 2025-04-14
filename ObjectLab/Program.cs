
using ObjectLab.Exeptions;
using ObjectLab.Models;

namespace ObjectLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MainMenu();
        }
        public static void MainMenu()
        {
            Console.Write("Enter hotel name ");
            string hotelName = Console.ReadLine();
            Hotel hotel = new Hotel(hotelName);

            switch (GetAndValidateUserChoiseForMainMenu())
            {
                case 0:
                    break;
                case 1:
                    SubMenu(hotel);
                    break;
                default:
                    throw new SomethingWentWrongException();
            }
        }
        public static int GetAndValidateUserChoiseForMainMenu()
        {
            Console.WriteLine("Enter system press => 1");
            Console.WriteLine("Exit press => 0");
            int userChoise = 0;
            while (!int.TryParse(Console.ReadLine(), out userChoise))
            {
                Console.WriteLine("Try valid choise!");
            }

            return userChoise;
        }
        public static int GetAndValidateUserChoiseForSubMenu()
        {
            Console.WriteLine("Create Room press => 1");
            Console.WriteLine("View roooms press => 2");
            Console.WriteLine("Reserve room press => 3");
            Console.WriteLine("Go back menu press => 4");
            Console.WriteLine("Exit press => 0");
            Console.WriteLine();
            int userChoise = 0;
            while (!int.TryParse(Console.ReadLine(), out userChoise))
            {
                Console.WriteLine();
                Console.WriteLine("Try valid choise!");
            }

            return userChoise;
        }
        public static void SubMenu(Hotel hotel)
        {
            Room hotelRoom = new Room("", 0, 0);
            while (true)
            {
                switch (GetAndValidateUserChoiseForSubMenu())
                {
                    case 1:
                        Console.WriteLine();
                        Console.WriteLine("Enter room name ");
                        string roomName = Console.ReadLine();
                        Console.WriteLine();
                        Console.WriteLine("Enter room price ");
                        decimal roomPrice = 0;
                        while (!decimal.TryParse(Console.ReadLine(), out roomPrice))
                        {
                            Console.WriteLine();
                            Console.WriteLine("Enter valid price");
                        }
                        Console.WriteLine();
                        Console.WriteLine("Enter person capacity");
                        int personCapacity = 0;
                        while (!int.TryParse(Console.ReadLine(), out personCapacity))
                        {
                            Console.WriteLine();
                            Console.WriteLine("Enter valid capacity");
                        }
                        Room room = new Room(roomName, roomPrice, personCapacity);
                        hotel.AddRoom(room);
                        hotelRoom = room;
                        break;
                    case 2:
                        foreach (Room item in hotel.GetAll())
                            Console.WriteLine(item.ShowInfo());
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.WriteLine();
                        Console.WriteLine("Enter roomId");
                        int roomIdForReservation = 0;
                        while (!int.TryParse(Console.ReadLine(), out roomIdForReservation))
                        {
                            Console.WriteLine();
                            Console.WriteLine("Enter valid input");
                        }
                        Console.WriteLine();
                        Console.WriteLine("Enter count of people");
                        int countOfPeopleForReservation = 0;
                        while (!int.TryParse(Console.ReadLine(), out countOfPeopleForReservation))
                        {
                            Console.WriteLine();
                            Console.WriteLine("Enter valid input");
                        }
                        try
                        {
                            hotel.MakeReservation(roomIdForReservation, countOfPeopleForReservation);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        Console.WriteLine();
                        Console.WriteLine("Room reserved");
                        break;
                    case 4:
                        MainMenu();
                        break;
                    case 0:
                        return;
                    default:
                        break;
                }
            }
        }

        public static Hotel CreateHotel()
        {
            Console.Write("Enter hotel name ");
            string hotelName = Console.ReadLine();
            Hotel hotel = new Hotel(hotelName);
            return hotel;
        }
    }
}
