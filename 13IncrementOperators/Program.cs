using System;

namespace _13IncrementOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            //a++; // same as a = a + 1;
            ++a; // same as a++
            Console.WriteLine(a);

            int x;
            x = 20;
            int increaseByOne = ++x; // same as x = 20 + 1

            Console.WriteLine(increaseByOne);
        }
    }
}
