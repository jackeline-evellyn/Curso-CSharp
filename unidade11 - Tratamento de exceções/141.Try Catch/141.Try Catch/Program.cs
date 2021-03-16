using System;

namespace _141.Try_Catch
{
    class Program
    {
        static void Main(string[] args)
        {
            //bloco a ser executado
            try
            {

                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                int result = n1 / n2;
                Console.WriteLine(result);

            }
            //Codigo a ser executado caso uma exceção ocorra
            //catch (Exception e) {
            catch (DivideByZeroException) { 
                Console.WriteLine("Division by zero is not allowed ");
            }
            catch(FormatException e)
            {
                Console.WriteLine("Format error! " + e.Message);
            }
        }
    }
}
