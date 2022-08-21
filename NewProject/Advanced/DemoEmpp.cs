using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.Advanced
{
    class DemoEmpp
    {
        static void Main(string[] args)
        {
            SortedList<Empp, string> ss = new SortedList<Empp, string>();
            ss.Add(new Empp(1, "Riya", "IT"), "A");
            ss.Add(new Empp(2, "Shweta", "Computer"), "A");
            ss.Add(new Empp(3, "Ojasvi", "Civil"), "A");
            ss.Add(new Empp(4, "Priy", "Mechanical"), "A");
            ss.Add(new Empp(5, "Rani", "ETC"), "A");

            foreach (KeyValuePair<Empp, string> kv in ss)
                Console.WriteLine(kv.Key + "==>" + kv.Value);



        }

    }
}
