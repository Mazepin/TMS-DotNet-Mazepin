using System;

namespace Mazepin.Homework5_ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            // ATM put, get money

            Atm atm = new Atm();
            atm.BalanceCard += InfoBalance;

            Console.WriteLine($"Hello! Your curently balance is: 0 BYN");

            while (true)
            {
                Console.WriteLine("\nPress the key corresponding to the required operation: ");
                Console.WriteLine("Put money Press - 1 ");
                Console.WriteLine("Get money Press - 2 ");
                Console.WriteLine("Show balance Press - 3 ");
                Console.WriteLine("Exit Press - 4 ");

                string selectionButton = Console.ReadLine();
                switch (selectionButton)
                {
                    case "1":
                        Console.Write("\nEnter the amount of money to put:");
                        decimal amountMoneyPut = decimal.Parse(Console.ReadLine());
                        atm.PutMoney(amountMoneyPut);
                        Console.WriteLine("===============");
                        break;

                    case "2":
                        Console.Write("\nEnter the amount of money to get:");
                        decimal amountMoneyGet = decimal.Parse(Console.ReadLine());
                        atm.GetMoney(amountMoneyGet);
                        Console.WriteLine("===============");
                        break;

                    case "3":
                        atm.GetInfo();
                        break;

                    case "4":
                        Console.WriteLine("Goodbye! Thank you for using our bank ");
                        return;

                    default:
                        Console.WriteLine("Шncorrect input!!!");
                        break;
                }
            }
        }
        public static void InfoBalance(decimal amount, string operation)
        {
            Console.WriteLine($"Operation {operation}. Balance: {amount} BYN");
        }
    }
}



