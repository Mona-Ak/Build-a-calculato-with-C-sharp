﻿using System;

namespace CalculatorCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter a number:");
            //double num1 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Enter another number:");
            //double num2 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine(num1 + num2);

            //building a better calculator
            Console.Write("Enter a number:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Operator:");
            string op = Console.ReadLine();

            Console.Write("Enter a number:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if (op == "+")
            {
                Console.Write(num1 + num2);
            }else if (op == "-")
            {
                Console.Write(num1 - num2);
            }else if (op == "/")
            {
                Console.Write(num1 / num2);
            }else if (op == "*")
            {
                Console.Write(num1 * num2);
            }else
            {
                Console.WriteLine("invalid operator");
            }

            Console.ReadLine();
        }
    }
}
