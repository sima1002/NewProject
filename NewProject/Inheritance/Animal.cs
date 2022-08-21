using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.Inheritance
{
    class Animal
    {
        protected string name="dog";
       
    }
    class Dog:Animal
    {
        protected string n = "Tigar";
        public void show()
        {
            Console.WriteLine("name" +name);
        }
        static void Main()
        {
            Dog d = new Dog();

            d.show();   
        }
    }
}
