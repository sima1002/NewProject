using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.Advanced.Assignment_1
{
    class InUpDele_1
    {
        static void Main(string[] args)
        {
            List<string> lst = new List<string>();
            lst.Add("sima");
            lst.Add("Jui");
            lst.Add("Ojasvi");
            lst.Add("Raj");
            lst.Add("Ram");

            lst.Insert(2,"Vaibhav");

            lst.Remove("Raj");

            


            foreach (string s in lst)
                Console.WriteLine(s);




           
           
            

            

        }
    }
}

