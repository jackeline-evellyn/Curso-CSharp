using System;
using System.Collections.Generic;
using System.Text;
using _123.Exercicio_proposto.Entities.Enums;
using System.Globalization;

namespace _123.Exercicio_proposto.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order()
        {

        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }
        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }
        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }
        public double Total()
        {
            double sum = 0.0;
            foreach(OrderItem item in Items)
            {
                sum += item.SubTotal();
            }
            return sum;
        }
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("ORDER SUMMARY: ");
            stringBuilder.AppendLine("Order moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            stringBuilder.AppendLine("Order status: " + Status);
            stringBuilder.AppendLine("Client: " + Client);
            stringBuilder.AppendLine("Order items: " );
            foreach(OrderItem item in Items)
            {
                stringBuilder.AppendLine(item.ToString());
            }
            stringBuilder.AppendLine("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));

            return stringBuilder.ToString();
        }

    }
}
