using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.Encapsulation
{
    class Department
    {
        private int did;
        private string dname;

        public int Did
        {
            get { return did; }
            set { did = value; }
        }
        public string Dname
        {
            get { return dname; }
            set { dname = value; }
        }
    }
    class Emp
    {
        private int id;
        private string name;
        private Department dept;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Department Dept
        {
            get { return dept; }
            set { dept = value; }
        }


    }
    class Empinfo
    {
        static void Main(string[]Args)
        {
            Emp e = new Emp();
            e.Id = 101;
            e.Name = "Dinesh";
          //  e.Dept = new Department();
            Department d = new Department();
            d.Did = 1;
            d.Dname = "HR";

            Console.WriteLine(e.Id + " " + e.Name + " " + d.Did + " " + d.Dname);
        }
    }
}
