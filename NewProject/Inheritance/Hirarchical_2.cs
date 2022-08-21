using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.Inheritance
{
    class Department
    {
        protected int subject = 3;

    }
    class Computer:Department
    {
        public void show()
        {
            string subject = "PHP";
            Console.WriteLine("computer :"   + subject);
        }
    }
    class Electronic:Department
    {
        public void display()
        {
            string subject = "Applied physics";
            Console.WriteLine("Elecronic :"    + subject);
        }
    }
    class Civil:Department
    {
        public void output()
        {
            string subject = "Structural Analysis";
            Console.WriteLine("Civil :"   + subject);

        }
    }
    class Hirarchical_2
    {
        static void Main(string[]args)
        {
            Computer c = new Computer();
            c.show();
            Electronic e = new Electronic();
            e.display();
            Civil s = new Civil();
            s.output();
        }
    }
}
