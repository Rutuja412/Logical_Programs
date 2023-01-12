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
            Console.WriteLine("Perfect Number");
            PerfectNumbers perfectNumber = new PerfectNumbers();
            perfectNumber.perfect();
            Console.WriteLine("Perfect Number");
            PrimeNumbers primeNumbers = new PrimeNumbers();
            primeNumbers.prime();
        }
    }
}
