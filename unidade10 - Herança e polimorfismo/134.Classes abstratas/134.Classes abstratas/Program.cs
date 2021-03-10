using System;
using System.Globalization;
using System.Collections.Generic;
using _134.Classes_abstratas.Entities;

namespace _134.Classes_abstratas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Classes Abstratas: Não podem ser instanciadas
            //herança total
            //abstract class Account - UML em Italico

            //Account acc1 = new Account(1001, "Alex", 500.0);
            Account acc2 = new SavingsAccount(1002, "Anna", 500.0, 0.01);

            //acc1.Withdraw(10.0);
            acc2.Withdraw(10.0);

            //Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);

            //posso ultilizar uma classe abastrata como lista
            //possivel misturar dois tipos herdados
            List<Account> list = new List<Account>();

            list.Add(new SavingsAccount(1001, "Alex", 500.0, 0.01));
            list.Add(new BusinessAccount(1002, "Maria", 500.0, 400.0));

            double sum = 0.0;
        foreach (Account account in list)
            {
                sum += account.Balance;   
            }
            Console.WriteLine("Total Balance: "+ sum.ToString("F2", CultureInfo.InvariantCulture));

            //Outra possibilidade: polimorfismo

            foreach(Account account1 in list)
            {
                account1.Withdraw(10.0);
            }
            foreach(Account account1 in list)
            {
                Console.WriteLine("Updated balance for account"
                    + account1.Number
                    + ": "
                    + account1.Balance.ToString("F2", CultureInfo.InvariantCulture)
                    ); 
            }
        }

       
    }
}
