using System;

namespace _1TheIfStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            // If
            int a, b;
            a = 10;b = 5;

            if (a >= b)
            {
                Console.WriteLine($" {a} > {b}. True");
            }

            if (4 <= 5)
            {
                Console.WriteLine("5 <= 4 True");
            }

            if (5 == 5)
            {
                Console.WriteLine("5 == 5 True");
            }

            if (5 != 4)
            {
                Console.WriteLine("5 != 4 True");
            }

            // If Else
            string name = "John";
            if (name == "John1")
            {
                Console.WriteLine("True. Name equals to {0}", name);
            }
            else
            {
                Console.WriteLine("False. Name NOT equal to {0}", name);
            }

            // Nested If
            int invoiceTotal = 1000;
            if (invoiceTotal == 1000)
            {
                string invoiceNumber = "INV001";
                if (invoiceNumber=="INV001")
                {
                    Console.WriteLine($"Yes. Invoice with number {invoiceNumber} exists.");
                }
            }

            // If Else If
            int employeeNumber = 123;

            if (employeeNumber == 123)
            {
                Console.WriteLine("Such employee exists with number {0}", employeeNumber);
            }
            else if (employeeNumber == 234)
            {
                Console.WriteLine("Such employee exists with number {0}", employeeNumber);
            }
            else
            {
                Console.WriteLine("Such employee does not exist with number {0}", employeeNumber);
            }
        }
    }
}
