/*using System;
using System.Collections.Generic;
using System.Text;

namespace myproject
{
    class Clculator
    {
        static void Main(String[] args)
        {
            int num1;
            int num2;
            String operand;
            float answer;
            Console.WriteLine("Enter the first integer");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter operand(+,-,*,/):");
            operand = Console.ReadLine();
            Console.WriteLine("Enter second integer");
            num2= Convert.ToInt32(Console.ReadLine());
            switch(operand)
            {
                case "-":
                    answer = num1 - num2;
                    break;
                case "+":
                    answer = num1 + num2;
                    break;
                case "*":
                    answer = num1 * num2;
                    break;
                case "/":
                    
                    answer = num1 / num2;
                    break;
                default:answer = 0;
                    break;
            }
                Console.WriteLine(num1.ToString()+" "+operand+" "+num2.ToString()+" = "+answer.ToString());
                Console.ReadLine();
        }
    }
}*/
