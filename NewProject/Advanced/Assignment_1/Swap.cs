using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.Advanced.Assignment_1
{
    class Swap
    {
        static void Main(string[] args)
        {
            List<string> ll = new List<string>() { "om", "Raj", "Darsh" };

            string temp = ll[1];
            ll[1] = ll[2];
            ll[2] = temp;

            foreach (string s in ll)
                Console.WriteLine(s);
        }
    }
}
