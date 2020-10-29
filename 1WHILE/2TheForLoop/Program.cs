using System;

namespace _2TheForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            // basic usage
            for (int i = 0; i <= 10; i++)
            {
                // break and continue usage
                if (i == 3)
                    continue; // when the condition is met then the loop continues

                // by using logic we can stop the loop if a condition is met by using the keyword break
                if (i == 5)
                    break;

                Console.WriteLine(i);
            }

            // another more complex example

            int page = 1;
            int totalPages = 10;
            for (int i = page; i <= totalPages; i+=2)
                Console.WriteLine($"Page {i}");
        }
    }
}
