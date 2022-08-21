using System;
using System.Collections.Generic;
using System.Text;

namespace myproject
{
    class EvenOdd
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("Enter a number");
            i = int.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                Console.WriteLine("Number is even");
                Console.Read();
            }
            else
            {
                Console.WriteLine("Number is odd");
                Console.Read();

            }
        }
    }
}
