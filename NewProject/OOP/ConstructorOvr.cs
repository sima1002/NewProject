using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.OOP
{
    class ConstructorOvr
    {
           public  ConstructorOvr()
            {
                 Console.WriteLine("Car Information:");
            }
          public  ConstructorOvr(int module)
            {
                 Console.WriteLine("Module:" + module);
            }
           public ConstructorOvr(string name)
            {
                 Console.WriteLine("Name:" + name);
            }
           public ConstructorOvr(double price)
            {
                 Console.WriteLine("Price:" + price);
            }
        
            static void Main(string[] args)
            {

                 ConstructorOvr c = new ConstructorOvr();
                 ConstructorOvr c1 = new ConstructorOvr(200);
                 ConstructorOvr c2 = new ConstructorOvr("Xylo");
                 ConstructorOvr c3 = new ConstructorOvr(550000);

            }
    }
}
