using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.TwoDArray
{
    class Addition_2DArray
    {
        static void Main(string[]args)
        {
            int i, j, n;
            int[,] a = new int[50,50];
            int[,] b = new int[50, 50];
            int[,] c = new int[50, 50];

            Console.Write("\n\nAddition of two Array:\n");
            Console.Write("............................");
            Console.Write("Enter the size of Array:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the element of first Array:\n");
            for(i=0;i<n;i++)
            {
                for(j=0;j<n;j++)
                {
                    Console.Write("Element [{0},{1}]:", i, j);
                    a[i, j] = Convert.ToInt32(Console.ReadLine());

                }
            }
            Console.Write("Enter the element of Second Array:\n");
            for (i = 0; i < n; i++)
            {
                Console.Write("\n");
                for (j = 0; j < n; j++)
                    Console.Write("{0}\t", b[i, j]);
            }
            for (i = 0; i < n; i++)
                for (j = 0; j < n; j++)
                    c[i, j] = a[i, j] + b[i, j];
            Console.Write("Addition of two array:\n");
            for(i=0;i<n;i++)
            {
                Console.Write("\n");
                for (j = 0; j < n; j++)
                    Console.Write("{0}\t", c[i, j]);
            }
            Console.Write("\n\n");

            

        }
    }
}
