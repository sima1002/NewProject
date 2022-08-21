using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.Loop
{
    class StarPattern
    {
        static void Main(string[] args)
        {

            for (int i = 0; i <= 4; i++)
            {
                for (int j = 0; j <=4; j++)
                {
                    if (i == j)
                    {
                        Console.Write(" * ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
