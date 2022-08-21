using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.Encapsulation
{
    class AddressP
    {
        
        
           public int pincode;
            public string city;

            public int Pincode
            {
                get;
                set;
            }
            public string City
            {
                get;
                set;
            }
    }

        class PersonP
        {
            int id;
            string name;
            AddressP adr;
            public int Id
            {
                get;
                set;
            }
           public string Name
            {
                get;
                set;
            }
            public AddressP Adr
            {
                get;
                set;
            }
        }
    

    class Personinfo
    {
        static void Main(string[] args)
        {
            PersonP p = new PersonP();
            p.Id = 123;
            p.Name = "Riya";
            p.Adr = new AddressP();
            AddressP a = new AddressP();
            a.pincode = 413306;
            a.city = "Pune";

            Console.WriteLine(p.Id + " " + p.Name + " " + a.Pincode + " " + a.City);
        }
    }
}
