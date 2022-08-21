using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.Assignment
{
    class SqureOdd_3
    {
        static void Main(string[] args)
        {
            int i = 0;
            Console.WriteLine("Even Numbers:");
            for (i = 1; i <= 50; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");

                }
            }
            Console.WriteLine("Odd Numbers:");
            for (i = 1; i <= 50; i++)
            {
                if (i % 2 != 0)
                {
                    double Sqr = Math.Pow(i, 2);
                    Console.WriteLine("Squre of {0} is : {1}", i, Sqr);
                }
            }
        }
    }
}
