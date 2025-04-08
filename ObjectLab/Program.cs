using ObjectLab.Models;

namespace ObjectLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = MakeNewLibrary();
            Book book = MakeNewBook();
            library.AddBook(MakeNewBook());

            while (true)
            {
                Console.WriteLine("1.Add Book");
                Console.WriteLine("2.Get book by Id");
                Console.WriteLine("3.Remove book");
                Console.WriteLine("4.Update book");
                Console.WriteLine("5.Get all books");
                Console.WriteLine("0.Quit");
                Console.WriteLine();
                string userChoise = Console.ReadLine();

                switch (userChoise)
                {
                    case "1":
                        library.AddBook(MakeNewBook());
                        break;
                    case "2":
                        library.GetBookById(GetAndValidateId());
                        break;
                    case "3":
                        library.RemoveBookById(GetAndValidateId());
                        break;
                    case "4":
                        library.Update(GetAndValidateId(), MakeNewBook());
                        break;
                    case "5":
                        library.GetAllBooks();
                        break;
                    case "0":
                        return;
                    default:
                        break;
                }

            }
        }
        public static Book MakeNewBook()
        {
            Console.WriteLine("Make Book : ");
            Console.Write("Enter book's name : ");
            string bookName = Console.ReadLine();
            Console.WriteLine("Enter author's name : ");
            string authorName = Console.ReadLine();
            Console.WriteLine("Enter book's price");
            decimal price = 0;
            while (!decimal.TryParse(Console.ReadLine(), out price))
            {
                Console.WriteLine("Enter correct price!");
                Console.WriteLine("Enter book's price");
            }
            Book book = new Book(bookName, authorName, price);
            Console.Clear();
            return book;
        }
        public static Library MakeNewLibrary()
        {
            Console.WriteLine("Make Library : ");
            Console.Write("Enter library name : ");
            string libraryName = Console.ReadLine();
            Library library = new Library(libraryName);
            Console.Clear();
            return library;
        }
        public static int GetAndValidateId()
        {
            int id = 0;
            Console.Write("Enter Id : ");
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("Enter Id Correctly!");
            }
            return id;
        }
    }
}
