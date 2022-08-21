using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.Advanced.Assignment_2
{
    class Emp_4
    {
        string nm;
        int experience;
        public Emp_4()
        {

        }
        public Emp_4 (string nm,int experience)
        {
            this.nm=nm;
            this.experience = experience;

        }
        public string Nm
        {
            set { this.nm = value; }
            get { return this.nm; }

        }
        public override bool Equals(object obj)
        {
            return obj is Emp_4 emp &&
                nm == emp.nm &&
                experience == emp.experience;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(nm, experience);
        }
        public override string ToString()
        {
            return "Name:" + nm + "Expirence:" + experience;
        }
    }

    class HashEmp
    {
        static void Main(string[] args)
        {
            HashSet<Emp_4> hs = new HashSet<Emp_4>();
            hs.Add(new Emp_4("Riya", 5));
            hs.Add(new Emp_4("Sujay", 8));
            hs.Add(new Emp_4("Nitin", 4));
            hs.Add(new Emp_4("Mohit", 10));
            hs.Add(new Emp_4("Amit", 5));

            foreach (Emp_4 e in hs)
                Console.WriteLine(e);
        }
    }
}
