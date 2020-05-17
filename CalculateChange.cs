using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Final_Delap
    {
     
        static void getPurchaseAmt(ref double purchaseAmt)
        {
            Random num = new Random();
            purchaseAmt = num.Next(0, 500) * 0.01;
        }

        static void getAmtPaid(ref double paidAmt)
        {
            Random num = new Random();
            paidAmt = (num.Next(0, 50) % 6) + 5;
        }

        static void calcChange(ref double actualChange, ref double purchaseAmt, ref double paidAmt, ref int dollars, ref int quarters, ref int dimes, ref int nickels, ref int pennies)
        {
            double remainder;
            actualChange = paidAmt - purchaseAmt;
            double change = actualChange;
            if (change % 1 == 0)
            {
                dollars = Convert.ToInt32(change);
            }
            else
            {
                remainder = change % 1;
                dollars = Convert.ToInt32(change - remainder);
            }
                    
            change -= dollars;

            if (change % .25 == 0)
            {
                quarters = Convert.ToInt32(change / .25);
            }
            else
            {
                remainder = change % .25;
                quarters = Convert.ToInt32((change - remainder) / .25);
            }
                    
            change -= (quarters * .25);

            if (change % .1 == 0)
            {
                dimes = Convert.ToInt32(change / .1);
            }
            else
            {
                remainder = change % .1;
                dimes = Convert.ToInt32((change - remainder) / .1);
            }
                    
            change -= (dimes * .1);

            if (change % .05 == 0)
            {
                nickels = Convert.ToInt32(change / .05);
            }
            else
            {
                remainder = change % .05;
                nickels = Convert.ToInt32((change - remainder) / .05);
            }
                    
            change -= (nickels * .05);
    
            pennies = Convert.ToInt32(change / .01);

            }

        static void outputChange(double acutalChange, double purchaseAmt, double paidAmt, int dollars, int quarters, int dimes, int nickels, int pennies)
        {
            Console.WriteLine("The amount of your purchase was: {0:C}", purchaseAmt);
            Console.WriteLine("The amount you paid was: {0:C}", paidAmt);
            Console.WriteLine("The amount of your change is: {0:C}", acutalChange);
            Console.WriteLine("Ones: {0} \nQuarters: {1} \nDimes: {2} \nNickels: {3} \nPennies: {4}", dollars, quarters, dimes, nickels, pennies);
        }

        static void Main(string[] args)
        {
            char cont = 'Y';
            int dollars = 0;
            int quarters = 0;
            int dimes = 0;
            int nickels = 0;
            int pennies = 0;
            double purchaseAmt = 0;
            double paidAmt = 0;
            double actualChange = 0;

            while (cont == 'Y')
            {
                getPurchaseAmt(ref purchaseAmt);
                getAmtPaid(ref paidAmt);
                calcChange(ref actualChange, ref purchaseAmt, ref paidAmt, ref dollars, ref quarters, ref dimes, ref nickels, ref pennies);
                outputChange(actualChange, purchaseAmt, paidAmt, dollars, quarters, dimes, nickels, pennies);
                Console.WriteLine("Would you like to make another purchase? Y/N");
                cont = Convert.ToChar(Console.ReadLine());
            }
        }
    }
}
