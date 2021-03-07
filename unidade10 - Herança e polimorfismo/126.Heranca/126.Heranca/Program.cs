using System;
using _126.Heranca.Entities;

namespace _126.Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Herança relação "é-um"
            Generalização (generica)/ especialização (possui outros atributos)
            Superclasse (classe base) / subclasse (classe derivada)
            Herança é uma extensão
            Herança é uma associação entre classes (e não entre objetos)
             */

            BusinessAccount account = new BusinessAccount(8010,"Bob Brown", 100.0, 500.0);

            Console.WriteLine(account.Balance);

            //account.Balance(200);
            //nao consegue, pois é protected


        }
    }
}
