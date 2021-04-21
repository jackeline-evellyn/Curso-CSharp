using System;
using _222.MulticastDelegates.Services;

namespace _222.MulticastDelegates
{
    class Program
    {
        delegate void BinaryNumericOperation(double n1, double n2);
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            BinaryNumericOperation op = CalculatorService.ShowSum;
            op += CalculatorService.ShowMax;

            op.Invoke(a, b);
        }
    }
}
