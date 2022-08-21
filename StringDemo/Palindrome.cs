using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.StringDemo
{
    class Palindrome
    {
        public static void Main(string[]args)
        {
            Console.WriteLine("Enter the string:");
            string str = Console.ReadLine();
            string revser = "";
            for(int i=str.Length-1;i>=0;i--)
            {
                revser = revser + str[i];

            }
            Console.WriteLine(revser);
            if(revser.Equals(str))
            {
                Console.WriteLine("String is Palindrome");

            }
            else
            {
                Console.WriteLine("String is not Palindrome");
            }
            Console.ReadLine();

        }
    }
}
