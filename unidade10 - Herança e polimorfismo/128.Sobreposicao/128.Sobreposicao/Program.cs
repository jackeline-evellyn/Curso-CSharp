using System;
using _128.Sobreposicao.Entities;

namespace _128.Sobreposicao
{
    class Program
    {
        static void Main(string[] args)
        {
            //Para que um objeto possa ser sobreposto deve ser incluído nesse o prefixo "virtual"
            //Ao sobreescrever um metodo devemos usar o prefixo override

            Account acc1 = new Account(1001, "Alex", 500.0);
            Account acc2 = new SavingAccount(1002, "Anna", 500.0, 0.01);

            acc1.Withdraw(10.0);
            acc2.Withdraw(10.0);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);

        }
    }
}
