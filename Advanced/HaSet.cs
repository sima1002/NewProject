using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.Advanced
{
    class HaSet
    {
        static void Main(string[] args)
        {
            string s = new string("Amit");
            string s1 = new string("Amit");

            Console.WriteLine(s.GetHashCode());
            Console.WriteLine(s1.GetHashCode());

            HashSet<string> hs1 = new HashSet<string>()
            { "Om","Raj","Siya","Ram"};

            HashSet<string> hs2 = new HashSet<string>()
            { "Omkar","Raja","Ram","Siya"};



            hs1.IntersectWith(hs2);

            hs1.UnionWith(hs2);

            bool b1 = hs1.IsSubsetOf(hs2);
            bool b2 = hs2.IsSubsetOf(hs1);

            foreach (string n in hs1)
                Console.Write(n + " ");

            Console.WriteLine();

            foreach (string n in hs2)
                Console.Write(n + " ");
        }
    }
}
