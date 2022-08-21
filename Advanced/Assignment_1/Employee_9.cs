using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.Advanced.Assignment_1
{
   public class Employee_9
   {
        public string name;
        public int age;
        public string designation;

        public Employee_9(string name,int age,string designation)
        {
            this.name = name;
            this.age = age;
            this.designation = designation;
        }
        public override string ToString()
        {
            return "name:" + " " + age + " " + designation;
        }
    }
    public class Emp1
    {
        public static void Main(string []args)
        {
            Employee_9 Rajesh = new Employee_9("Rajesh", 35, "HR");
            Employee_9 Nitin = new Employee_9("Nitin", 45, "CEO");
            Employee_9 Sangita = new Employee_9("Sangita", 30, "Developer");

            List<Employee_9> emp = new List<Employee_9>()
            { Rajesh,Nitin ,Sangita };

            emp.Sort((x,y)=>x.age.CompareTo(y.age));
            Console.WriteLine(string.Join(Environment .NewLine, emp));

            Console.WriteLine("After descending age:");
            emp.Reverse();
            foreach (var Employee_9 in emp)
                Console.WriteLine(Employee_9 );

        }
    }
}
