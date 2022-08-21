using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.Loop
{
    class CountOddNo_1_to_20
    {
        static void Main(string[] args)
        {
            int sum = 1;
            for(int i=1;i<=20;i=i+2)
            {
                Console.WriteLine(i);
                sum = sum + i;
            }
            Console.WriteLine(sum);

        }
    }
}
