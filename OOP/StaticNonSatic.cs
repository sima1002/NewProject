using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.OOP
{
    class StaticNonSatic
    {
        static int x=12;
        int y=45;
        public void Addition()
        {
            Console.WriteLine("Addition" + (x + y));
        }
        public static void Division()
        {
            StaticNonSatic s = new StaticNonSatic();
            Console.WriteLine("Division" + (x / s.y));
        }

    }
    class Solution
    {
        static void Main(string[] args)
        {
            StaticNonSatic d = new StaticNonSatic();
            d.Addition();
            StaticNonSatic.Division();
        }
    }
}
