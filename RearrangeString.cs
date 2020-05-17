using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Week_10_Challenge_Delap
    {
        static void Main(string[] args)
        {
            string[] compositeString = { "4for", "2is the", "3week 10 challenge assignment", "1This assignment", "5CIS243" };
            Array.Sort(compositeString);

            for (int i = 0; i < compositeString.Length; i++)
            {
                compositeString[i] = compositeString[i].Substring(1);
            }

            foreach (string sub in compositeString)
            {
                Console.Write(sub + " ");
            }
            Console.WriteLine();
        }
    }
}
