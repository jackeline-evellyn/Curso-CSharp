using System;
using _115.Enumeracoes.Entities;
using _115.Enumeracoes.Entities.Enums;

namespace _115.Enumeracoes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Enumeração - enum
            //Enum - tipo valor
            //Serve para especificar um conjunto de constantes relacionadas
            //O compilador não permite colocar outro valor além dos definidos


            Order order = new Order
            {
                Id = 1000,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            //Converter o valor de Enum para string
            string txt = OrderStatus.PendingPayment.ToString();
            Console.WriteLine(txt);

            //De String para enum
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine(os);


        }
    }
}
