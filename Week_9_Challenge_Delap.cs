using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Week_9_Challenge_Delap
    {
        static void calculate(ref string[] areaCodes, ref double[] rates, ref Boolean found, ref string areaCode, ref string minutes)
        { 
            Console.Write("What area code are you calling? ");
            areaCode = Convert.ToString(Console.ReadLine());

            for (int i = 0; i < areaCodes.Length; i++)
            {
                if (areaCode == areaCodes[i])
                {
                    Console.Write("How many minutes is your call? ");
                    minutes = Convert.ToString(Console.ReadLine());
                    Console.Write("Your phone call to area code {0} costs ${1} per minute.", areaCode, rates[i]);
                    string cost = Convert.ToString((Convert.ToDouble(minutes))*rates[i]);
                    Console.WriteLine("\nFor {0} minutes the total is ${1:C}", minutes, cost);
                    found = true;
                    break;
                }
            }


        }
        static void Main(string[] args)
        {
            string[] areaCodes = new string[6] { "262", "414", "608", "715", "815", "920" };
            double[] rates = new double[6] { 0.07, 0.10, 0.05, 0.16, 0.24, 0.14 };
            Boolean found = false;
            string areaCode = "";
            string minutes = "";

            calculate(ref areaCodes, ref rates, ref found, ref areaCode, ref minutes);
            if (found == false)
            {
                Console.WriteLine("Sorry - no calls allowed to area code {0}", areaCode);
            }
        }
    }
}
