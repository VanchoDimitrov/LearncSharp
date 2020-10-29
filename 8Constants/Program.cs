using System;

namespace _8Constants
{
    class Program
    {
        static void Main(string[] args)
        {
            const int a = 5;
            //a = 10; // you can't do that because value is already assigned and it is of a type constant​
            int b = 8;
            int sum;
            b = 10; // this is allowed. You can override value for a variables​
            sum = b + a;
            Console.WriteLine($"The SUM equals {sum}");
        }
    }
}
