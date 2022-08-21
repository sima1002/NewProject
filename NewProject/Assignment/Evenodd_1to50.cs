using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.Assignment
{
    class Evenodd_1to50
    {

        static void Main(string[] args)
        {
            int i = 0;
            Console.WriteLine("Even Numbers:");
            for(i=1;i<=50;i++)
            {
                if(i%2==0)
                {
                    Console.Write(i + " ");

                }
            }
            Console.WriteLine("Odd Numbers:");
            for(i=1;i<=50;i++)
            {
                if(i%2!=0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
