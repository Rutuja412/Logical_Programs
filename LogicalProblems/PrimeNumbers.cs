using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalProblems
{
    internal class PrimeNumbers
    {
        public void prime()
        {
            int num, count = 0;
            Console.Write("Enter number: ");
            num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                Console.WriteLine(num + " is prime number");
            }
            else
            {
                Console.WriteLine(num + " is not prime number");
            }
        }
    }
}
