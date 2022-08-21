using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.Inheritance
{
    class Father
    {
        protected string name = "Son";
    }
    class Firstson : Father
    {
        public void show()
        {
            name = "Rahul";
            Console.WriteLine("First"  + name);
        }
            
    }
    class Secondson : Father
    {
        public void display()
        {
            name = "Nitin";
            Console.WriteLine("Second"  + name);
        }
    }
    class Thirdson : Father
    {
        public void output()
        {
            name = "Suraj";
            Console.WriteLine("Third"  + name);
        }
    }




    class Hirarchical
    {
        static void Main(string[]args)
        {
            Thirdson t = new Thirdson();
            t.output();
            Secondson s = new Secondson();
            s.display();
            Firstson f = new Firstson();
            f.show();
        }
    }
}
