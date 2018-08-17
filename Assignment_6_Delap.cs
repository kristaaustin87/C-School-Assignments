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


//Hypotenuse catches
	//add c variable
	if (a==0 || b == 0 || c == 0){
		textBox3.Text = "Error. A triangle cannot have a side length of 0";
		}
		
	else if ((a == null && b == null) || (b == null && c == null) || (a == null && c == null)){
		textBox3.Text = "Error. Must enter two side's lengths to find the third.";
		}
		
	else if (c == null){
		//current code
		}
		
	else if (a == null){
		a = Math.Sqrt((Math.Pow(c,2) - (Math.Pow(b,2));
		textBox1.Text = a;
		}
	else {
		b = Math.Sqrt((Math.Pow(c,2) - (Math.Pow(a,2));
		textBox2.Text = b;
		}
		
//Add perimeter and area to tringle, will need different triangle options