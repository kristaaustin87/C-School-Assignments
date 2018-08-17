using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week_3_Challege_Delap
{
    class Week_3_Challenge_Delap
    {
        static void Main(string[] args)
        {
            decimal wage;
            decimal hours;
            decimal gross;
            decimal net;

            Console.Write("Enter the hourly rate: ");
            wage = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Enter hours worked: ");
            hours = Convert.ToDecimal(Console.ReadLine());

            if (hours > 40)
            {
                gross = Math.Round((((hours - 40) * ((decimal)1.5 * wage)) + ((decimal)40 * wage)),2);
            }

            else
            {
                gross = Math.Round((hours * wage),2);
            }

            if (gross <= 1000)
            {
                if (gross <= 600)
                {
                    net = Math.Round((gross - (gross * (decimal).1)),2);
                }

                else
                {
                    net = Math.Round((gross - (gross * (decimal).21)),2);
                }
            }

            else
            {
                net = Math.Round((gross - (gross * (decimal).28)),2);
            }


            Console.Write("Gross pay is " + gross + " and net pay is " + net + ".");
            
        }
    }
}
