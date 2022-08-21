using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.Inheritance
{
    class Parent
    {
        protected string name = "Father";
    }
    class Son:Parent
    {
        protected string n = "Child";

        public void show()
        {
            Console.WriteLine(" name " + name);
        }
        static void Main()
        {
            Son s = new Son();

            s.show();
        }
    }
}
