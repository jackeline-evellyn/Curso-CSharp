using System;
using System.Collections.Generic;
using System.Text;

namespace _128.Sobreposicao.Entities
{
    class BusinessAccount : Account
    {
        public double LoanLimit { get; set; }

        public BusinessAccount()
        {

        }

        //: base() -> realiza as atribuições na classe principal
        public BusinessAccount(int number, string holder, double balance, double loanLimit) : base(number, holder, balance)
        {

            LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;
            }
        }


    }
}