using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.Advanced.Assignment_2
{
    class SortElement_1
    {
        static void Main(string[] args)
        {
            List<string> l = new List<string>();
            l.Add("Sima");
            l.Add("Riya");
            l.Add("Ojasvi");
            l.Add("Dinesh");
            l.Add("Vaibhav");

            foreach (string s in l)
                Console.WriteLine(s);

            Console.WriteLine("After Sorting");

            l.Sort();

            foreach (string s in l)
                Console.WriteLine(s);

        }
    }
}
