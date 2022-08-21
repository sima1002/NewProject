using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.Advanced
{
    class ClassStrCount
    {
        static void Main(string[] args)
        {
            List<string> ll = new List<string>()
            { "red","pink","black","red","yellow","red" };

            Dictionary<string, int> dd = new Dictionary<string, int>();

            foreach(string color in ll)
            {
                if(dd.ContainsKey(color))
                {
                    int oldvalue = dd[color];
                    dd[color] = oldvalue + 1;
                }
                else
                {
                    dd.Add(color, 1);
                }
            }
        }
    }
    class EEE
    {
        static void Main(string[] args)
        {


            List<string> ll = new List<string>()
            { "red","pink","black","red","yellow","red" };

            string colorTodeleted = "red";
            ll.Remove(colorTodeleted);

            while(true)
            {
                int idx = ll.IndexOf(colorTodeleted);
                if (idx != -1)
                    ll.RemoveAt(idx);
                else
                    break;

            }

            foreach (string d in ll)
                Console.WriteLine(d);
        }

    }
}
