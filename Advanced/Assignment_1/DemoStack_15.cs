using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.Advanced.Assignment_1
{
    class DemoStack_15
    {
        static void Main(string[] args)
        {
            Stack<string> st = new Stack<string>();

            st.Push("Raj");
            st.Push("Kuhu");
            st.Push("Dinesh");
            st.Push("Ram");

            //string dataremove = st.Pop();

            string datapeek = st.Peek();
            Console.WriteLine("Peek" + datapeek);

            foreach (string d in st)
                Console.WriteLine(d);
        }
    }
}
