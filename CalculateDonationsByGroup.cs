using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Challenge_5_Delap
    {
        public class gradeCalc
        {
            public int GradeTotal;
            public decimal GradeAmt;
            public decimal gradeAvg;

            public gradeCalc(int gradeTotal, decimal gradeAmt)
            {
                GradeTotal = gradeTotal;
                GradeAmt = gradeAmt;
            }

            public void calcAvg(int GradeTotal, decimal GradeAmt)
            {
                if (GradeTotal == 0)
                {
                    gradeAvg = 0;
                }

                else
                {
                    gradeAvg = GradeAmt / GradeTotal;
                }
            }

            public void displayMessage(int GradeTotal, decimal GradeAmt, decimal gradeAvg)
            {
                Console.WriteLine("\t\t{0}\t\t{1:C}\t\t\t{2:C}",GradeTotal,GradeAmt,gradeAvg);
            }
        }
        static void Main(string[] args)
        {
            int grade = 0;
            decimal amt;
            
            gradeCalc gradeCalc6 = new gradeCalc(0,0);
            gradeCalc gradeCalc7 = new gradeCalc(0,0);
            gradeCalc gradeCalc8 = new gradeCalc(0,0);

            while (grade != 999)
            {
                Console.WriteLine("Please enter the grade of the contributor (6, 7, or 8) or enter 999 to quit.");
                grade = Convert.ToInt32(Console.ReadLine());

                if (grade == 999)
                { break; }

                else
                {
                    Console.WriteLine("Please enter the amount of contribution:");
                    amt = Convert.ToDecimal(Console.ReadLine());

                    switch (grade)
                    {
                        case 6:
                            gradeCalc6.GradeTotal++;
                            gradeCalc6.GradeAmt += amt;
                            break;

                        case 7:
                            gradeCalc7.GradeTotal++;
                            gradeCalc7.GradeAmt += amt;
                            break;

                        case 8:
                            gradeCalc8.GradeTotal++;
                            gradeCalc8.GradeAmt += amt;
                            break;
                    }
                }
            }

            gradeCalc6.calcAvg(gradeCalc6.GradeTotal, gradeCalc6.GradeAmt);
            gradeCalc7.calcAvg(gradeCalc7.GradeTotal, gradeCalc7.GradeAmt);
            gradeCalc8.calcAvg(gradeCalc8.GradeTotal, gradeCalc8.GradeAmt);

            Console.WriteLine("Grade Level \t # of Contributors \t Total Amount \t Average Contribution");
            Console.Write("6th Grade");
            gradeCalc6.displayMessage(gradeCalc6.GradeTotal, gradeCalc6.GradeAmt, gradeCalc6.gradeAvg);

            Console.Write("7th Grade");
            gradeCalc7.displayMessage(gradeCalc7.GradeTotal, gradeCalc7.GradeAmt, gradeCalc7.gradeAvg);
           
            Console.Write("8th Grade");
            gradeCalc8.displayMessage(gradeCalc8.GradeTotal, gradeCalc8.GradeAmt, gradeCalc8.gradeAvg);

            if (gradeCalc6.GradeAmt > gradeCalc7.GradeAmt && gradeCalc6.GradeAmt > gradeCalc8.GradeAmt)
            {
                Console.WriteLine("Congratulations 6th graders!");
            }

            else if (gradeCalc7.GradeAmt > gradeCalc8.GradeAmt && gradeCalc7.GradeAmt > gradeCalc6.GradeAmt)
            {
                Console.WriteLine("Congratulations 7th graders!");
            }

            else if (gradeCalc8.GradeAmt > gradeCalc7.GradeAmt && gradeCalc8.GradeAmt > gradeCalc6.GradeAmt)
            {
                Console.WriteLine("Congratulations 8th graders!");
            }
            else
            {
                if (gradeCalc6.GradeAmt == gradeCalc7.GradeAmt)
                {
                    Console.WriteLine("It's a tie. Congratulations 6th and 7th graders!");
                }

                else if (gradeCalc6.GradeAmt == gradeCalc8.GradeAmt)
                {
                    Console.WriteLine("It's a tie. Congratulations 6th and 8th graders!");
                }

                else if (gradeCalc7.GradeAmt == gradeCalc8.GradeAmt)
                {
                    Console.WriteLine("It's a tie. Congratulations 7th and 8th graders!");
                }

                else
                {
                    Console.WriteLine("It's a tie!");
                }
  
            }
        }
    }
}
