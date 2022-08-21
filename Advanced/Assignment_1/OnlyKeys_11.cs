using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.Advanced.Assignment_1
{
    class OnlyKeys_11
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> d = new Dictionary<int, string>();
            d.Add(1, "Maths");
            d.Add(2, "English");
            d.Add(3, "Chemistry");
            d.Add(4, "Physics");
            d.Add(5, "Science");

            List<int> keys = new List<int>(d.Keys);

            foreach (int n in keys)
                Console.WriteLine(n);

        }


    }
}
