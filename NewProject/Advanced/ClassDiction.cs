using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.Advanced
{
    class ClassDiction
    {
        static void Main(string[]args)
        {
           

            Dictionary<string, int> dd = new Dictionary<string, int>();
            dd.Add("Sima", 89);
            dd.Add("Raj", 80);
            dd.Add("Ojasvi", 92);

            Console.WriteLine(dd["Raj"]);
            Console.WriteLine(dd["Sima"] = 91);

            dd.Remove("Sima");

            dd.Clear();

            dd.ContainsKey("Ojasvi");
            dd.ContainsValue(80);

            foreach (KeyValuePair<string, int> kp in dd)
                Console.WriteLine(kp.Key + "=>" + kp.Value);
        }
    }
}
