using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.Inheritance
{
    class Employee
    {
        protected int salary = 60000;
    }
    class Programer:Employee
    {
        protected int bonus = 10000;

        public void show()
        {
            Console.WriteLine(" salary " + bonus);
        }
        static void Main()
        {
            Programer s = new Programer();

            s.show();
        }
    }
}

