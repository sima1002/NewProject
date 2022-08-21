using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.Advanced.Assignment_2
{
    class Movie_7
    {
        static void Main(string[] args)
        {
            Stack<string> s = new Stack<string>();
            s.Push("Vivaah");
            s.Push("Hum Sath Sath Hain");
            s.Push("Tanhaji");
            s.Push("Hum Apke Hain Kon");
            s.Push("DDLJ");

            s.Pop();

            foreach (string ss in s)
                Console.WriteLine(ss);

        }
    }
}
