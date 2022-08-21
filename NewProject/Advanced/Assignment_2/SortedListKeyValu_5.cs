using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.Advanced.Assignment_2
{
    class SortedListKeyValu_5
    {
        static void Main(string[] args)
        {
            SortedList<int, string> ss = new SortedList<int, string>();
            ss.Add(1, "Computer");
            ss.Add(2, "IT");
            ss.Add(3, "Civil");
            ss.Add(4, "Mechanical");
            ss.Add(5, "E&TC");

            foreach (KeyValuePair<int, string> p in ss)
                Console.WriteLine(p.Key +"====>"+p.Value);
        }
    }
}
