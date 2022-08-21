using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.StringDemo
{
    class TogleString
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Enter the string");
            string str = Console.ReadLine();
            string newstr = "";
            for(int i=0;i<str.Length;i++)
            {
                char ch = str[i];
                if(char.IsUpper(ch))
                {
                    ch = (char)(ch + 32);
                }
                else if(char.IsLower(ch))
                {
                    ch = (char)(ch - 32);
                }
            }
        }
    }
}
