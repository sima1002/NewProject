using System;
using System.Collections.Generic;
using System.Text;

namespace myproject
{
    class DemoHash
    {
        static void Main(string[] args)
        {
            
            
                string s1=new string("Amit");
                string s2 = new string("Amit");
                Console.WriteLine(s1.GetHashCode());
                Console.WriteLine(s2.GetHashCode());

               // Emp e1 = new Emp("om", 3);
               // Emp e2 = new Emp("om", 3);
               // Console.WriteLine(e1.GetHashCode());

            
        }
    }
}
