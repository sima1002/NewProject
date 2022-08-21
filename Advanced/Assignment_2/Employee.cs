using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.Advanced.Assignment_2
{

   public class Employee
   {
        public string name;
        public string designation;
        public int salary;

        public Employee(string name,string designation,int salary)
        {
            this.name = name;
            this.designation = designation;
            this.salary = salary;
        }
        public override string ToString()
        {
            return (name+" "+designation +" "+salary );
        }
        public string Name { get => name; set => name = value; }
        public string Designation { get => designation ; set => designation  = value; }
        public int Salary { get => salary; set => salary = value; }
   }

    class Emp
    {
        static void Main(string[] args)
        {
            List<Employee> e = new List<Employee>();

            e.Add(new Employee("Raj", "HR", 60000));
            e.Add(new Employee("Rahim", "CEO", 80000));
            e.Add(new Employee("Sita", "Trainee", 40000));
            e.Add(new Employee("Rani", "Developer", 50000));

            foreach (Employee em in e)
                Console.WriteLine(em);
        }
    }
}
