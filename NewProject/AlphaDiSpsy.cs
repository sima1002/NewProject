using System;
using System.Collections.Generic;
using System.Text;

namespace myproject
{
    class AlphaDiSpsy
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the char");
            char ch= Console.ReadLine()[0];
            if((ch>='A'&&ch<='Z'))
            {
                Console.WriteLine("Alphabet");

            }
            else
            {
                Console.WriteLine("Not allowed");
            }
            if((ch>='0'&&ch<='9'))
            {
                Console.Write("Digit");
            }
            else
            {
                Console.WriteLine("Not allowed");
            }

        }
    }
}
