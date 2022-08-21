using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace myproject.Advanced.Assignment_1
{
    class Color_2
    {
        static void Main(string[] args)
        {
            List<string> ll = new List<string>();
            ll.Add("Red");
            ll.Add("Pink");
            ll.Add("White");
            ll.Add("Black");
            
            foreach (string color in ll)
            {
                Console.WriteLine(ll);
            }
        }
    }
}
