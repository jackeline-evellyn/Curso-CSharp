
namespace _131.Exercicio_Resolvido.Entities
{
    class Employee
    {
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHours { get; set; }

        public Employee()
        {

        }

        public Employee(string name, int hours, double valuePerHours)
        {
            Name = name;
            Hours = hours;
            ValuePerHours = valuePerHours;
        }

        //virtual = para que o metodo possa ser sobreescrito
        public virtual double Payment()
        {
            return Hours * ValuePerHours;
        }
    }
}
