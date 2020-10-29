using System;

namespace _1WHILE
{
    class Program
    {
        static void Main(string[] args)
        {
            // while loop
            int page = 1;
            int totalPages = 10;

            while (page <= totalPages)
            {
                Console.WriteLine(page);

                // you can also add logic within the while cycle
                if (page == 5)
                    Console.WriteLine("You are passed 5 page already!");

                //page++;
                page += 3; // we can control the number of times the loop executes
            }
        }
    }
}
