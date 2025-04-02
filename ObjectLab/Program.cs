namespace ObjectLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hotel hotel = CreateHotel();
            Room room = CreateRoom();

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("1. Create a room");
                Console.WriteLine("2. Add room");
                Console.WriteLine("3. Make reserve");
                Console.WriteLine("4. Show Info");
                Console.WriteLine("0. Exit");
                Console.WriteLine();

                string userChoise = Console.ReadLine();

                switch (userChoise)
                {
                    case "1":
                            Room newRoom = CreateRoom();
                            room = newRoom;
                        goto Add;
                        break;
                    case "2":
                        Add:
                        if (HasRoomBeenCreated(room))
                            hotel.AddRoom(room);
                        else
                            Console.WriteLine("First, create a room");
                        break;
                    case "3":
                        hotel.MakeReservation(room.Id);
                        break;
                    case "4":
                        Console.WriteLine(room.ShowInfo());
                        break;
                    case "0":
                        return;
                    default:
                        break;
                }


            }
        }

        public static string GetAndValidateRoomName(out string roomName)
        {
            Console.Write("Enter room name : ");
            roomName = Console.ReadLine();
            return roomName;
        }

        public static double GetAndValidateRoomPrice(out double price)
        {
            Console.Write("Enter room price : ");
            while (!double.TryParse(Console.ReadLine(), out price))
            {
                Console.WriteLine("Enter room price correctly! : ");
            }
                return price;
        }
        public static int GetAndValidatePersonCapacity(out int capacity)
        {
            Console.Write("Enter person capacity : ");
            while (!int.TryParse(Console.ReadLine(), out capacity))
            {
                Console.WriteLine("Enter person capacity correctly : ");
            }
            return capacity;
        }

        public static Room CreateRoom()
        {
            string roomName;
            double roomPrice;
            int personCapacity;

            GetAndValidateRoomName(out roomName);
            GetAndValidateRoomPrice(out roomPrice);
            GetAndValidatePersonCapacity(out personCapacity);

            Room room = new Room(roomName, roomPrice, personCapacity);

            Console.WriteLine();
            Console.WriteLine("Room created");

            return room;
        }
        public static Hotel CreateHotel()
        {
            Console.Write("Enter Hotel name : ");
            string hotelName = Console.ReadLine();
            Hotel hotel = new Hotel(hotelName);
            Console.WriteLine();
            return hotel;
        }

        public static bool HasRoomBeenCreated(Room room)
        {
            return room != null;
        }
    }
}
