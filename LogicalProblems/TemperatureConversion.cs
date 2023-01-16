using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalProblems
{
    internal class TemperatureConversion
    {
        public static float F, C, Fahrenheit, Celsius;
        public static void temperaturConversionToFahrenheit()
        {
            Fahrenheit = (C * 9 / 5) + 32;
            Console.Write("\n Celsius to Fahrenheit: " + Fahrenheit);
        }
        public static void temperaturConversionToCelsius()
        {
            Celsius = (F - 32) * 5 / 9;
            Console.Write("\nFahrenheit to Celsius : " + Celsius);
        }
    }
}
