namespace ObjectLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which currency do you want? USD = 0/EUR = 1/RUB = 2/TRY = 3");
            int usersCurrencyChoise = 0;
            while (!int.TryParse(Console.ReadLine(), out usersCurrencyChoise))
            {
                Console.WriteLine("Enter correct choise! 0/1/2/3");
            }
            Console.WriteLine();

            Console.WriteLine("Enter AZN value : ");
            double valueForCurrencyTransfer = 0;
            while (!double.TryParse(Console.ReadLine(), out valueForCurrencyTransfer))
            {
                Console.WriteLine("Write correctly/Something went wrong.");
            }
            Console.WriteLine();


            switch (usersCurrencyChoise)
            {
                case (int)Currency.USD:
                    CalculateCurrency(Currency.USD, valueForCurrencyTransfer);
                    break;
                case (int)Currency.RUB:
                    CalculateCurrency(Currency.RUB, valueForCurrencyTransfer);
                    break;
                case (int)Currency.EUR:
                    CalculateCurrency(Currency.EUR, valueForCurrencyTransfer);
                    break;
                case (int)Currency.TRY:
                    CalculateCurrency(Currency.TRY, valueForCurrencyTransfer);
                    break;
                default:
                    break;
            }

        }
        public static void CalculateCurrency(Currency currency, double azn)
        {
            switch (currency)
            {
                case Currency.EUR:
                    Console.WriteLine($"{azn / 2}");
                    break;
                case Currency.USD:
                    Console.WriteLine($"{azn / 1.7}");
                    break;
                case Currency.RUB:
                    Console.WriteLine($"{azn / 0.02}");
                    break;
                case Currency.TRY:
                    Console.WriteLine($"{azn / 0.05}");
                    break;
                default:
                    break;
            }
        }
    }
}
