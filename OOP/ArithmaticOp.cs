using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.OOP
{
    class ArithmaticOp
    {
       // int x;
       // int y;
        public void Arithmatic()
        {
            Console.WriteLine("Addition=" + (6 + 7));
        }
        public void Arithmatic(int a,int b)
        {
            Console.WriteLine("Subsrtaction=" + (a - b));

        }
        public void Arithmatic(int x,int y,float z)
        {
            Console.WriteLine("Multiplication=" + (x * y * z));
        }
        public void Arithmatic(float a,float b)
        {
            Console.WriteLine("Division=" + (a / b));
        }
        static void Main(string[] args)
        {
            ArithmaticOp s = new ArithmaticOp();
            s.Arithmatic();
            s.Arithmatic(20,10);
            s.Arithmatic(2,6,2.5f);
            s.Arithmatic(10.0f,2.5f);
        }
    }
}
