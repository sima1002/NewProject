using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.TwoDArray
{
    class SumOfColumn
    {
        public static void Main(string[]args)
        {
            int[,] a = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            for(int i=0;i<a.GetLength(1);i++)
            {
                int sum = 0;
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    sum = sum + a[j, i];
                    Console.Write(a[j, i] + "  ");
                }
                Console.Write("    " + sum);
                Console.WriteLine();
            }
          
        }
    }
}
