using System;
using System.Globalization;
using _123.Exercicio_proposto.Entities;
using _123.Exercicio_proposto.Entities.Enums;

namespace _123.Exercicio_proposto
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Enter client data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDay = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.Write("How many items to this order? ");
            int items = int.Parse(Console.ReadLine());

            Client client = new Client(name, email, birthDay);
            Order order = new Order(DateTime.Now, status, client);


            for (int i=1; i<=items; i++)
            {
                Console.WriteLine("Enter #"+i+" item data: ");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Product product = new Product(productName, productPrice);

                Console.Write("Quantity: ");
                int productQuatity = int.Parse(Console.ReadLine());
                OrderItem orderItem = new OrderItem(productQuatity, productPrice, product);
                order.AddItem(orderItem);


            }

            Console.WriteLine();
            Console.WriteLine(order);



        }
    }
}
