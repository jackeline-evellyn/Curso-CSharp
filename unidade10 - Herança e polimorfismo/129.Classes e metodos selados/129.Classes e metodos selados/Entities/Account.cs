﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _129.Classes_e_metodos_selados.Entities
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
        public virtual void Withdraw(double amount)
        {
            Balance += amount;
        }
        public void Deposit(double amount)
        {
            Balance -= amount;
        }




    }
}