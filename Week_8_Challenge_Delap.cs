using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Week_8_Challenge_Delap
    {
        static void Main(string[] args)
        {
            decimal[] prices = new decimal[10];
            decimal sum = 0;
            decimal avg;

            for (int i = 0; i < prices.Length; i++)
            {
                Console.Write("Enter price " + (i+1) + " ");
                prices[i] = Convert.ToDecimal(Console.ReadLine());
            }

            foreach (decimal p in prices)
            {
                sum += p;
            }

            avg = Math.Round((sum / 10),2);

            Console.WriteLine("The sum of the values entered is: {0}", sum);

            Console.Write("Prices less than $5.00: ");
            foreach (decimal p in prices)
            {
                if (p < 5)
                {
                    Console.Write("$" + p + " ");
                }
            }

            Console.WriteLine("\nThe average price is: {0}", avg);
            Console.Write("Prices higher than average: ");
            foreach (decimal p in prices)
            {
                if (p > avg)
                {
                    Console.Write("$" + p + " ");
                }
            }

            Console.WriteLine();
        }
    }
}
