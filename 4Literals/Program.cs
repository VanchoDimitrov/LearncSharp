using System;

namespace _4Literals
{
    class Program
    {
        static void Main(string[] args)
        {
            // printing char literal
            Console.WriteLine('V');


            // printing a string as a char will cause an error
            //Console.WriteLine('Software Engineer');

            // printing a string
            Console.WriteLine("Your Name");


            // printing an integer literal
            Console.WriteLine(098); // we don't use single or double quotes for this

            // printing double as a literal
            Console.WriteLine(2.54m); // we need to include the literal sufix m or M for doubles

            // printing bool value
            Console.WriteLine(true);
            Console.WriteLine(false);
        }
    }
}
