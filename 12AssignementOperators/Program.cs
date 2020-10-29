using System;

namespace _12AssignementOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            a += 5; // it will increase 10 by 5
            // same as a = a + 5;
            Console.WriteLine(a); // Outputs 15

            a = 10; // we still need to initialize the variable a with a new value.
            //in our case the same value of 10 because the previous value for a is taken which is 15
            a -= 5; // it will decrease 10 by 5
            // same as a = a - 5;
            Console.WriteLine(a); // Outputs 5

            a = 10;
            a *= 5; // it will multiply 10 by 5
            // same as a = a * 5;
            Console.WriteLine(a); // Outputs 50

            a = 10;
            a /= 5; // it will divide 10 with 5
            // same as a = a / 5;
            Console.WriteLine(a); // Outputs 2
        }
    }
}
