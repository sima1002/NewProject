using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.Advanced.Assignment_1
{
    class ContentDictionary_10
    {
        static void Main(string[] args)
        {
            
            Dictionary<string, int> dd = new Dictionary<string, int>();
            dd.Add("Sima", 89);
            dd.Add("Raj", 80);
            dd.Add("Ojasvi", 92);

           
           
            foreach (KeyValuePair<string, int> kp in dd)
                Console.WriteLine(kp.Key + "=>" + kp.Value);
        }
    }
}

