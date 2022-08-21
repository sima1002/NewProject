using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.Loop
{
    class Pattern4321
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <=4 ; i++)
            {
                for (int j = 4; j >= i; j--)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
