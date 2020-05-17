using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Assignment_6_Delap
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double c;

            Console.WriteLine("To Quit Enter 0");

            do
            {
                Console.Write("Enter side 1: ");
                a = (Convert.ToDouble(Console.ReadLine()));

                Console.Write("Enter side 2: ");
                b = (Convert.ToDouble(Console.ReadLine()));

                    if (a == 0 && b == 0)
                    {
                        break;
                    }

                c = Math.Sqrt((Math.Pow(a, 2)) + (Math.Pow(b, 2)));
                Console.WriteLine("The hypotenuse is {0}", c);
            }
            while (a != 0 && b != 0);
        }
    }
}
