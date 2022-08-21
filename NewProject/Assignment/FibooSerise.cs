using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.Assignment
{
    class FibooSerise
    {

        static void Main(string[] args)
        {
            int n, a = 0, b = 1, c, i;
            Console.Write("Enter the Number of Terms:");
            n = Int32.Parse(Console.ReadLine());
            for(i=0;i<n;i++)
            {
                if(i<=1)
                {
                    c = i;
                }
                else
                {
                    c = a + b;
                    a = b;
                    b = c;
                }
                Console.Write(c + " ");
            }
            Console.ReadKey();
        }
    }
}
