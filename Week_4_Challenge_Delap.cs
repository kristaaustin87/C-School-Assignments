using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Week_4_Challenge_Delap
    {
        static void Main(string[] args)
        {
            double sales;
            int salesmanNumber = 1;
            double empPay;
            double commRate1 = 0.10;
            double commRate2 = 0.20;
            double commRate3 = 0.30;

            while (salesmanNumber != 0)
            {
                Console.WriteLine("Enter Employee Sales #: ");
                salesmanNumber = Convert.ToInt32(Console.ReadLine());

                if (salesmanNumber = 0)
                {
                    Console.WriteLine("Ending Program");
                }

                else
                {
                    Console.WriteLine("Enter sales amount for Employee {0}", salesmanNumber);
                    sales = Convert.ToDouble(Console.ReadLine());

                    if (sales > 3000)
                    {
                        empPay = 0;
                        Console.WriteLine("Invalid Sales Entry");
                    }

                    else if (sales >= 500 && sales <= 1000)
                    {
                        empPay = sales * commRate1;
                    }

                    else if (sales > 1000 && sales <= 2000)
                    {
                        empPay = sales * commRate2;
                    }

                    else if (sales > 2000 && sales <= 3000)
                    {
                        empPay = sales * commRate3;
                    }

                    else
                    {
                        empPay = sales;
                    }

                    Console.WriteLine("The pay for Salesman #{0} is {1}.", salesmanNumber, empPay);
                }
            }
        }
    }
}
