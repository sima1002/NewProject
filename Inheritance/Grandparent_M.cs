using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.Inheritance
{
    class Grandparent_M
    {
        protected string name = "GrandFather";
    }

    class Parent_M : Grandparent_M
    {
        protected string n = "Father";
    }
    class Son_M : Parent_M
    {
        protected string na= "Chlid";
    

        public void display()
        {
            Console.WriteLine( name +" "+name+" "+ name);
        }
        static void Main()
        {
            Son_M s = new Son_M();

            s.display();
        }
    }
}
