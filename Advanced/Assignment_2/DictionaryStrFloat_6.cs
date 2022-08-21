using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.Advanced.Assignment_2
{
    class DictionaryStrFloat_6
    {
        static void Main(string[] args)
        {
            Dictionary<string, float> dd = new Dictionary<string, float>();

            dd.Add("Circle", 3.14f);
            dd.Add("Square", 7.2f);
            dd.Add("Rectangle", 9.23f);
            dd.Add("Cone", 6.664f);

            foreach (KeyValuePair<string, float> k in dd)
                Console.WriteLine(k.Key + "====>" + k.Value);
        }
    }
}
