using System;
using System.Collections.Generic;
using System.Text;


namespace Mazepin.Homework5_ATM
{
    public class Atm
    {
        public event Action<decimal, string> BalanceCard;

        private decimal balance = 0;

        public void GetInfo ()
        {
            var eventName = "show";
            BalanceCard?.Invoke(balance, eventName);
        }

        public void PutMoney (decimal money)
        {
            balance += money;
            BalanceCard?.Invoke(balance, "put money");
        }

        public void GetMoney (decimal money)
        {
            balance -= money;
            BalanceCard?.Invoke(balance, "get money");
        }
    }
}

