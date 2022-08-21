using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.Advanced
{
    class DemoSortedSet
    {
        static void Main(string[] args)
        {
            SortedSet<string> ss = new SortedSet<string>();
            ss.Add("Raman");
            ss.Add("Leena");
            ss.Add("Heena");
            ss.Add("Beena");
            ss.Add("Raman");

            foreach (string d in ss)
                Console.WriteLine(d);
        }
    }
}
