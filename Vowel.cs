using System;
using System.Collections.Generic;
using System.Text;

namespace myproject
{
    class Vowel
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter character");
            char ch = Console.ReadLine()[0];
            if(ch=='a')
            {
                Console.WriteLine("Vowel");
             
            }
            else if(ch=='e')
            {
                Console.WriteLine("Vowel");
            }
            else if (ch == 'i')
            {
                Console.WriteLine("Vowel");
            }
            else if (ch == 'o')
            {
                Console.WriteLine("Vowel");
            }
            else if (ch == 'u')
            {
                Console.WriteLine("Vowel");
            }
            else
            {
                Console.WriteLine("Constant");
            }
        }
    }
}
