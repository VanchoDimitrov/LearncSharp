using System;

namespace _11MultipleArithmeticOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            // In this case by default the compiler will do the multiplication and then will do the addition​
            int result = 3 + 4 * 2;
            Console.WriteLine(result);

            // By using parentheses we enforce that first we do the addition and after the multiplication.
            // Same as in mathematics​
            result = (3 + 4) * 2;
            Console.WriteLine(result);
        }
    }
}
