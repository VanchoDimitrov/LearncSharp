using System;

namespace _4ConditionalOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 20;
            int b = 22;

            int result = (a >= b) ? 1 : 2;
            string otherResult = (a >= b) ? "Yes" : "No";
            bool boolResult = (a >= b) ? true : false;
            // it means that if the condition is met assign value 1 if not assign value 2

            Console.WriteLine(result); // print the result of the above condition
            Console.WriteLine(otherResult);
            Console.WriteLine(boolResult);

            // the above code is replaces the following statement
            if (a >= b)
            {
                Console.WriteLine(1.ToString());
            }
            else
            {
                Console.WriteLine(2.ToString());
            }
        }
    }
}
