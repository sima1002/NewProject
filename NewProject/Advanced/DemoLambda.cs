using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.Advanced
{
    public delegate int mydele1(int n);
    class DemoLambda
    {
        static void Main(string[]args)
        {
            mydele1 a = (n) =>
            {
                  int i, f = 1;
                  for (i = 1; i <= n; i++)
                  {
                      f = f * i;
                  }
                  return f;
            };
            int e = a(4);
            Console.WriteLine(e);
        }
    }
}
