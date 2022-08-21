using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.Loop
{
    class SumofPrimeno
    {
        static void Main(string[] args)
        {
            bool isPrime = true;
            int i, j;
            Console.WriteLine("Prime numbers are");
            for(i=1;i<=10;i++)
            {
                for(j=2;j<i;j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }
            if(isPrime)
            {
                Console.Write("\t" + i);
            }
            isPrime = true;
            Console.ReadLine();



              
        }
    }
}
