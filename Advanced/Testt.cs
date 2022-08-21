using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.Advanced
{
    class SS<T>
    {
        private T obj;
        public T Obj { get => obj; set => obj = value; }

    }

    class S
    {
        private Object obj;
        public object Obj { get => obj; set => obj = value; }
    }
    class Testt
    {
        //Non Generic
        static void Main(string[]args)
        {
            SS<float> s1 = new SS<float>();
            s1.Obj = 4.5f;
            float d = s1.Obj;

            S s = new S();
            s.Obj = "Omkar";
            s.Obj = 9000;

            int x = (int)s.Obj;
        }

    }
}
