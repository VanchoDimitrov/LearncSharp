using System;

namespace Begginers
{
    class Program
    {
        static void Main(string[] args)
        {
            // arithmetic operations with literals
            Console.WriteLine(5 + 5); // 10
            Console.WriteLine(10 - 5); // 5
            Console.WriteLine(5 * 5); // 25
            Console.WriteLine(10 / 2); // 5

            Console.WriteLine(24 % 7); // 3 is the remainder

            // variables

            int a, b;
            a = 5;
            b = 5;

            Console.WriteLine($"a+b {a + b}");
            Console.WriteLine($"a-b {a - b}");
            Console.WriteLine($"a*b {a * b}");
            Console.WriteLine($"a/b {a / b}");


            int sum;
            sum = a + b * 10;
            Console.WriteLine(sum); // 55

            sum = (a + b) * 10;
            Console.WriteLine(sum); // 100
        }
    }
}
