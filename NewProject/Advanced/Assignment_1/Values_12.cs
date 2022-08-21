using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.Advanced.Assignment_1
{
    class Values_12
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> d = new Dictionary<int, string>();
            d.Add(1, "Maths");
            d.Add(2, "English");
            d.Add(3, "Chemistry");
            d.Add(4, "Physics");
            d.Add(5, "Science");

            Dictionary<int, string>.ValueCollection values = d.Values;

            foreach (string s in values)
                Console.WriteLine(s);

        }
    }
}
