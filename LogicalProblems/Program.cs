using System;

namespace LogicalProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Welcome to the logical c-sharp programs");
            Console.WriteLine("Select given options");
            Console.WriteLine("1.Fibonacci Series\n2.Perfect Number\n3.Prime Number\n4.ReverseNumber\n5.StopWatchSimulation\n6.DayWeek\n7.TemperatureConversion\n8.Montholy Payment \n9.Exit ");
            int option = Convert.ToInt16(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Fibonacci Series");
                    FibonacciSeries fibonacciSeries = new FibonacciSeries();
                    fibonacciSeries.series();
                    break;
                case 2:
                    Console.WriteLine("Perfect Number");
                    PerfectNumbers perfectNumber = new PerfectNumbers();
                    perfectNumber.perfect();
                    break;
                case 3:
                    Console.WriteLine("Prime Number");
                    PrimeNumbers primeNumbers = new PrimeNumbers();
                    primeNumbers.prime();
                    break;
                case 4:
                    Console.WriteLine("Reverse Number");
                    ReverseNumber reverseNumber = new ReverseNumber();
                    reverseNumber.reverse();
                    break;
                case 5:
                    Console.WriteLine("StopWatch");
                    StopWatchSimulation stopWatchSimulationstopWatchSimulation = new StopWatchSimulation(); 
                    stopWatchSimulationstopWatchSimulation.stopwatch();
                    break;
                    case 6:
                    Console.WriteLine("Day Of Week");
                    DayWeek dayWeek = new DayWeek();
                    dayWeek.week();
                    break;
                    case 7:
                   Console.Write("\nEnter value for Celcius to Fahrenheit conversion: ");
                    TemperatureConversion.C = Convert.ToInt32(Console.ReadLine());
                    TemperatureConversion.temperaturConversionToFahrenheit();
                    Console.Write("\nEnter value for Fahrenheit to celsius conversion: ");
                    TemperatureConversion.F = Convert.ToInt32(Console.ReadLine()); ;
                    TemperatureConversion.temperaturConversionToCelsius();
                    break;
                case 8:
                    Console.WriteLine("Montholy payment");
                    MonthlyPayment monthlyPayment = new MonthlyPayment();
                    monthlyPayment.FindMonthlyPayment();
                    break;
                default:
                    Console.WriteLine("Select valid options only ");
                    break;
            }
           
        }
    }
}
