using System;

namespace LogicalProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Logical Problems");
            Console.WriteLine("Fibonacci Series");
            FibonacciSeries fibonacciSeries = new FibonacciSeries();
            fibonacciSeries.series();
        }
    }
}
