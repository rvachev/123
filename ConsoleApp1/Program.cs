using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            double t = 0.392;
            double x = Math.Sin(t) * 1.8;
            double y = (t + 4) / (Math.Sin(t) * x);
            double result = Math.Pow(x, 3) * Math.Exp(-1 * x * y) * (Math.Sqrt(0.8 * x * y * t) / (Math.Cos(x) * Math.Log(y)));
            Console.WriteLine("Результат вычисления - " + result);
            Console.ReadKey();
        }
    }
}
