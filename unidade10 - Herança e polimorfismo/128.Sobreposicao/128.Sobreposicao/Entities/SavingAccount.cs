using System;
using System.Collections.Generic;
using System.Text;

namespace _128.Sobreposicao.Entities
{
    class SavingAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingAccount()
        {

        }
        public SavingAccount(int number, string holder, double balance, double interestRate)
              : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }
        //overide para sobreescrever o métoo
        public override void Withdraw(double amount)
        {
            base.Withdraw(amount); // pega os valores que já estavam na superclasse
            Balance -= 2.0;
        }
    }
}