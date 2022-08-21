using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.StringDemo
{
    class Revers
    {
      public static void Main(string[]args)
        {
            string str = "India is My Country";
            string revser = "";
            for(int i=0;i<str.Length;i++)
            {
                revser = str[i] + revser;
            }
            Console.WriteLine(revser);
        }
    }
}
