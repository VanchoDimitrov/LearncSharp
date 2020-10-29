using System;

namespace _3LogicalOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            // && Logical Operator
            int a = 22;
            int b = 44;

            // both conditions are false = false
            if (a >= b && a == 20) // also you can have multiple logical operators and conditions. In our case we have only 2 conditions
            {
                Console.WriteLine("Condition met.");
            }
            else
            {
                Console.WriteLine("Condition not met.");
            }

            // write the rest of the conditions by using logical operators. HOME WORK


            // || Logical operator

            if (a <= b || b != a)
            {
                Console.WriteLine($"The || OR condition is met.");
            }

            // ! NOT logical operator

            if (!(a == b)) // we are evaluating the condition
                Console.WriteLine("Not equal!");
        }
    }
}
