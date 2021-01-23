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

            Console.Write("\nEnter the amount of money to put:");
            decimal amountMoneyPut = decimal.Parse(Console.ReadLine());
            atm.PutMoney(amountMoneyPut);
            Console.WriteLine("===============");

            Console.Write("\nEnter the amount of money to get:");
            decimal amountMoneyGet = decimal.Parse(Console.ReadLine());
            atm.GetMoney(amountMoneyGet);
            Console.WriteLine("===============");

            Console.Write("\nСlick B to view balance "); // условно, можно нажать любую клавишу
            string balanceInfo = Console.ReadLine();
            atm.GetInfo();

            Console.ReadKey();
        }
        public static void InfoBalance(decimal amount, string operation)
        {
            Console.WriteLine($"Operation {operation}. Balance: {amount} BYN");
        }
    }
}



