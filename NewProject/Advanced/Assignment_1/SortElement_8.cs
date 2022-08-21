using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.Advanced.Assignment_1
{
    class SortElement_8
    {
        static void Main(string[] args)
        {
            List<string> student = new List<string>();

            student.Add("Raj");
            student.Add("Rajashwari");
            student.Add("Sangita");
            student.Add("Rahul");
            student.Add("Nitin");

            student.Sort();
            foreach (string s in student)
                Console.WriteLine(s);
        }
    }
}
