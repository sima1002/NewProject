using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.StringDemo
{
    class Pattern
    {
        public static void Main(string[]args)
        {
            string str = "I like India Country";
            string[] s = str.Split("");
            for(int i=0;i<=s.Length;i++)
            {
                for(int j=0;j<=i;j++)
                {
                    Console.Write(s[j]);
                }
                Console.WriteLine();
            }
            
        }
    }
}
