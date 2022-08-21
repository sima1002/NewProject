using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.Loop
{
    class Pattern1to6
    {
        static void Main(string[] args)
        {
            int c = 1;
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(c);
                    c++;
                }
                Console.WriteLine();
            }
        }
    }
}
