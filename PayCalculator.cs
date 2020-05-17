using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Assignment_4_Delap
    {
        static void Main(string[] args)
        {
            int count = 1;
            decimal hours;
            decimal rate;
            decimal gross;

            while (count <= 3)
            {
                Console.Write("Enter the hours worked for Employee " + count + ": ");
                hours = Convert.ToDecimal(Console.ReadLine());

                Console.Write("Enter the hourly rate for Employee " + count + ": ");
                rate = Convert.ToDecimal(Console.ReadLine());

                if (hours <= 40)
                {
                    gross = hours * rate;
                }

                else
                {
                    gross = (40 * rate) + ((hours - 40) * ((decimal) 1.5 * rate));
                }

                Console.WriteLine("The gross pay for Employee {0} is {1:C}.", count, gross);
                Console.WriteLine();

                count++;
            }
        }
    }
}
