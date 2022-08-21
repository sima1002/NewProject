using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.Advanced.Assignment_1
{
    class ReplaceEle_5
    {
        static void Main(string[] args)
        {
            List<int> l = new List<int>();
            l.Add(2);
            l.Add(3);
            l.Add(4);
            l.Add(5);
            l.Add(6);

            foreach (int i in l)
                Console.WriteLine(i);
            l.Insert(5, 9);
            foreach (int i in l)
                Console.WriteLine(i);
        }
    }
}
