using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.Assignment_5
{
    class UpperToLower
    {
        public static void Main()
        {
            string str;
            Console.WriteLine("Enter the String:");
            str = Console.ReadLine();
            Console.WriteLine("String in lowercase:{0}", str.ToLower());
            Console.ReadLine(); 
        }
    }
}
