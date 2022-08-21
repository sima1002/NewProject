using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.Encapsulation
{
    class Address
    {
        public int pincode;
        public string city;

        public Address(int pincode,string city)
        {
            this.pincode = pincode;
            this.city = city;
        }
        public void show()
        {
            Console.WriteLine(pincode + " " + city);
        }
    }

    class Person
    {
        int id;
        string name;
        Address adr;
        public Person(int id,string name,Address adr)
        {
            this.id = id;
            this.name = name;
            this.adr = adr;
        }
        void display()
        {
            Console.WriteLine(id + " " + name + " " + adr.pincode + " " + adr.city);
        }
        static void Main(string[]args)
        {
            Person p = new Person(101,"Raj",new Address(1234,"Solapur"));
            p.display();
        }
    }
}
