using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.Advanced.Assignment_1
{
    class DictionaryCust_18
    {
        class InvalidExperienceException : ApplicationException
        {

        }
        class Emp1 : Object
        {
            string nm;
            int experience;

            public string Nm
            {
                set { this.nm = value; }
                get { return nm; }
            }
            public override string ToString()
            {
                return "Name:" + nm + "Experience:" + experience;
            }
            public int Experience
            {
                set
                {
                    if (value < 0)
                        throw new InvalidExperienceException();
                    else
                        this.experience = value;
                }
                get { return experience; }
            }
        }
        class Cust
        {
            static void Main(string[] args)
            {
                Emp1 e1 = new Emp1();
                Console.WriteLine("Enter name and experience:");
                e1.Nm = Console.ReadLine();
                try
                {
                    e1.Experience = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Experience cant be negative");
                }
                Console.WriteLine(e1);

            }
        }
    }
}
