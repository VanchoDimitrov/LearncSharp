using System;

namespace _12WorkingWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            // concatenation between literal and a string
            string firstName = "Name";
            string name = firstName + "\tLast Name"; // \t tab space \n new line usage
            Console.WriteLine(name);

            // concatenation between two strings
            string a, b;
            a = "First Name";
            b = "Last Name";
            Console.WriteLine(a + ", " + b);

            // string interpolation
            Console.WriteLine($"Interpolation: {a} {b}");

            // interpolation between string and literal
            Console.WriteLine($"First Name {b}");

            // verbatim literals and literal string plus interpolation
            string folder = "MyFolder";
            Console.WriteLine($@"c:\{folder}\application.exe");
            Console.WriteLine("c:\\folder\\folder1");

            //SOME OTHER OPERATIONS WITH STRINGS

            // check the length of a given string
            string myName = "John";
            Console.WriteLine(myName.Length); // Outputs 4

            Console.WriteLine();

            // loop through the string
            for (int i = 0; i < myName.Length; i++)
            {
                //Console.WriteLine(myName[i]); // prints every letter vertically. John vertically.

                Console.Write(myName[i]); // print the name letter by letter horizontally
            }

            Console.WriteLine();

            // find the index of a letter of a string
            Console.WriteLine("'J' letter is located at index: {0}", myName.IndexOf('J')); // finds the index of letter 'J' which is 0

            Console.WriteLine();
            
            //myName = myName.Insert(0, "D"); // inserts letter D at index 0
            myName = myName.Replace("John","Monika");
            myName = myName.Substring(6); // prints from index 6 onwards = Dimitrov
            //myName = myName.Remove(0, 1); // removes J from index 0
            Console.WriteLine(myName);
            Console.WriteLine(myName[1]); // prints letter D
        }
    }
}
