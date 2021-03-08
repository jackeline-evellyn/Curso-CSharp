using System;
using System.Collections.Generic;
using System.Text;

namespace _127.Upcasting_e_downcasting.Entities
{
    class Account
    {
        public int Number { get; protected set; }
        public string Holder { get; protected set; }
        public double Balance { get; protected set; }

        public Account()
        {

        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }
        public void Withdraw(double amount)
        {
            Balance += amount;
        }
        public void Deposit(double amount)
        {
            Balance -= amount;
        }




    }
}