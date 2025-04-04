namespace ObjectLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your Full Name : ");
            string fullName = Console.ReadLine();

            while (!Helper.CheckFullName(fullName))
            {
                Console.WriteLine("Enter your name correctly");
                Console.Write("Enter your Full Name : ");
                fullName = Console.ReadLine();
            }
            Console.WriteLine();
            
            Console.Write("Enter your age : ");
            byte age = 0;
            while (!byte.TryParse(Console.ReadLine(), out age))
            {
                Console.WriteLine("Enter your age correctly!");
                Console.Write("Enter your age : ");
            }
            Console.WriteLine();

            Console.Write("Enter your Group Number : ");
            string groupNumber = Console.ReadLine();
            while (!Helper.CheckGroupNo(groupNumber))
            {
                Console.WriteLine("Enter your Group Number correctly!");
                Console.Write("Enter your Group Number : ");
                groupNumber = Console.ReadLine();
            }
            Console.WriteLine();

            Student student = new Student(fullName, groupNumber, age);
            Console.WriteLine("Student added");

            student.ShowInfo();
        }
    }
}
