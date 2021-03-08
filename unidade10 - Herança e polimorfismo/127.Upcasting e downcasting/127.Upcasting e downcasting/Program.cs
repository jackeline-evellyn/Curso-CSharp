using System;
using _127.Upcasting_e_downcasting.Entities;

namespace _127.Upcasting_e_downcasting
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(1001, "Alex", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

            //Palavras AS e IS

            //UPCASTING - Casting da subclasse para superclasse
            //ex: BussinessAccount para Accout
            //Uso comum: Polimorfismo

            Account acc1 = bacc; //O BussinessAccout é um accout
            Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
            Account acc3 = new SavingAccount(1004, "Anna", 0.0, 0.01);

            //DOWNCASTING - Casting da superclasse para subclasse 
            //Accout para Bussiness Accout

            //BusinessAccount acc4 = acc2; // Não aceitta pois está dentro de uma variavel Account
            BusinessAccount acc4 = (BusinessAccount)acc2; //cast
            acc4.Loan(100.0);
            //acc2.Loan(); //Funciona apenas no BusinessAccount

            //BusinessAccount acc5 = (BusinessAccount)acc3;
            //BussinessAccount não é compativel com Saving Account
            //Apenas em tempo de execução que foi possível prever isso


            //Downcasting é uma operação insegura, necessário testar a variável
            if(acc3 is BusinessAccount)//testando se é uma instancia de BusinessAccount
            {
                //BusinessAccount acc5 = (BusinessAccount)acc3;
                //outra forma de fazer
                BusinessAccount acc5 = acc3 as BusinessAccount;

                acc5.Loan(200.0);
                Console.WriteLine("Loan!");
            }
            if(acc3 is SavingAccount)
            {
               // SavingAccount acc5 = (SavingAccount)acc3;

                SavingAccount acc5 = acc3 as SavingAccount;
                acc5.UpdateBalance();
                Console.WriteLine("Update!");
            }

        }
    }
}