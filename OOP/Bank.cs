using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.OOP
{
    class Bank
    {
        int acc_no;
        string acc_type;
        string cust_name;
        int balance;

        public void input()
        {
            Console.WriteLine("Enter account number:");
            acc_no = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter account type:");
            acc_type = Console.ReadLine();
            Console.WriteLine("Enter customer name:");
            cust_name = Console.ReadLine();
            Console.WriteLine("Enter account balance:");
            balance = int.Parse(Console.ReadLine());
        }
        public void show()
        {
            Console.WriteLine();
            Console.WriteLine("Account Number:" + acc_no);
            Console.WriteLine("Account Type:" + acc_type);
            Console.WriteLine("Customer Name:" + cust_name);
            Console.WriteLine("Balance:" + balance);
        }
        public void withdraw()
        {
            Console.WriteLine("Enter amount you can withdraw:");
            int w = int.Parse(Console.ReadLine());
            balance = balance - w;
            display();
        }

             void deposit()
            {
                Console.WriteLine("Enter amount you can deposit:");
                int d = int.Parse(Console.ReadLine());
                balance = balance + d;
                display();

            }
             void display()
            {
                Console.WriteLine("Updated available balance is:" + balance);

            }

            static void Main(string[]args)
            {
                Bank b = new Bank();
                b.input();
                b.show();
                Console.WriteLine("Which operation you can perform w or d:");
                int op = char.Parse(Console.ReadLine());
                if (op == 'w')
                    b.withdraw();
                else if (op == 'd')
                    b.deposit();
                else
                    Console.WriteLine("Wrong choice:");
            }
        
    }
}
