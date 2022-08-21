using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.StringDemo
{
    class CountWord
    {
        public static void Main()
        {
            string str = "c# Java C Paython PHP HTML";
            int wordCount = 0;
            for(int i=0;i<str.Length;i++)
            {
                if(str[i]== ' ' &&Char.IsLetter(str[i+1])&&(i>0))
                {
                    wordCount++;
                }
            }
            wordCount++;
            Console.WriteLine("Total Number Of Words In Given String:" + wordCount);
        }
    }
}
