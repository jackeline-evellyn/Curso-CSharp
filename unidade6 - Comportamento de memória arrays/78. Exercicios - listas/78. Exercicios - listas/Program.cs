using System;
using System.Globalization;
using System.Collections.Generic;

namespace _78._Exercicios___listas
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("How many employees will be registered? ");
            int quantidade = int.Parse(Console.ReadLine());
            
            List<Funcionario> list = new List<Funcionario>();

            for (int i=0; i < quantidade; i++)
            {
                Console.WriteLine("Employee #" + (i+1) + ":");
                Console.Write("Id: ");
                int id= int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                list.Add(new Funcionario(id, name, salary));
                Console.WriteLine();
            
            }

            Console.Write("Enter the employee id that will have salary increase: ");
            int searchId = int.Parse(Console.ReadLine());

            Funcionario emp = list.Find(x => x.Id == searchId);
            if(emp != null)
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.increaseSalary(percentage);
            }
            else
            {
                Console.WriteLine("This id does not exist");
            }
            Console.WriteLine();
            Console.WriteLine("Updated list of employees: ");
            foreach (Funcionario obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
