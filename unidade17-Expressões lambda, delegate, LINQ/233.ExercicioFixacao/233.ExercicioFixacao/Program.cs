using System;
using System.Globalization;
using System.IO;
using System.Collections.Generic;
using _233.ExercicioFixacao.Entities;
using System.Linq;

namespace _233.ExercicioFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();

            List<Employee> employee = new List<Employee>();
            
            using(StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split(',');
                    string name = fields[0];
                    string email = fields[1];
                    double salary = double.Parse(fields[2], CultureInfo.InvariantCulture);

                    employee.Add(new Employee(name, email, salary));
                }
            }

            Console.Write("Enter salary: ");
            double minSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            var selectEmployee = employee.Where(p => p.Salary > minSalary).OrderBy(p => p.Email).Select(p => p.Email);
            Console.WriteLine("Email of people whose salary is more than " +minSalary.ToString("F2", CultureInfo.InvariantCulture));

            foreach( string email in selectEmployee)
            {
                Console.WriteLine(email);
            }

            double sum = employee.Where(p => p.Name[0] == 'M').Select(p => p.Salary).Sum();
            Console.WriteLine("Sum of salary of people whose name starts with 'M': " + sum.ToString("F2", CultureInfo.InvariantCulture));
            
        }
    }
}
