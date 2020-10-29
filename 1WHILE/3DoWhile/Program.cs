using System;

namespace _3DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            do
            {
                Console.WriteLine(i);
                //i++;
                i += 2;
            } while (i < 10);

            //the do while loop runs at least once. That is the difference between the while loop cycle.

            int ii = 10; // we start to count at 10 but we say while the counter is less than 5 which is non-sense.
            // the cycle will still run once.
            do
            {
                Console.WriteLine(ii);
                ii++;
            } while (ii < 5);
        }
    }
}
