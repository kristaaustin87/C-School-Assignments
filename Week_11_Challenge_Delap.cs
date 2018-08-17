using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Week_11_Challenge_Delap
    {
        static void Main(string[] args)
        {
            string bark = "Bark ";
            string meow = "Meow ";
            StringBuilder sound = new StringBuilder();

            for (int i = 1; i < 11; i++)
            {
                if (i % 2 == 0)
                {
                    sound.Append(meow);
                }
                else
                {
                    sound.Append(bark);
                }

                Console.WriteLine(sound);
            }
        }
    }
}
