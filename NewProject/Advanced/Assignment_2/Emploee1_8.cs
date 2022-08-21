using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.Advanced.Assignment_2
{
    class Emploee1_8:IComparable<Emploee1_8>
    {
        string nm;
        int experience;
        string designation;

        public Emploee1_8(string nm,int experience,string designation)
        {
            this.Name = nm;
            this.Experience = experience;
            this.Designation = designation;
        }
        public override string ToString()
        {
            return "Name:"+nm+ " "+"Experience:"+experience+" "+"Designation:"+" "+designation;
        }
        public int CompareTo(Emploee1_8 other)
        {
            return other.experience.CompareTo(this.experience);
        }
        public string Name { get => nm; set => nm = value; }
        public int Experience { get => experience ; set => experience  = value; }
        public string Designation { get => designation ; set => designation  = value; }
    }

    class EmpSort
    {
        static void Main(string []args)
        {
            SortedList<Emploee1_8, string> ss = new SortedList<Emploee1_8, string>();
            ss.Add(new Emploee1_8("Sima", 5, "Developer"), "IT");
            ss.Add(new Emploee1_8("Sanjay", 4, "Trainee"), "IT");
            ss.Add(new Emploee1_8("Oovi", 7, "Tester"), "IT");
            ss.Add(new Emploee1_8("Rohan", 9, "Manager"), "IT");
            foreach (KeyValuePair<Emploee1_8, string> k in ss)
                Console.WriteLine(k.Key +"====>" + k.Value);
        }
    }
}
