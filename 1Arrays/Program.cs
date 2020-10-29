using System;

namespace _1Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaration of an integer array

            int[] numbers = new int[5] { 0,1,2,3,4}; // we can store up to 5 numbers in the array
            //numbers[0] = 1; // 0 is the index of the array or the position. We assign a value 1 to the array with index = 0
            //numbers[1] = 2;
            //numbers[2] = 3;
            //numbers[3] = 4;
            //numbers[4] = 5;

            numbers[0] = 1111; //re-assign index 0 with another value

            Console.WriteLine("Prints the value of Index 0: {0}",numbers[0]); // prints the value 1 for index 0

            Console.WriteLine();

            // loop through the array
            for (int i = 0; i < numbers.Length;i++)
            {
                Console.WriteLine($" Array values: {numbers[i]}");
            }

            Console.WriteLine();

            // foreach does the same as the previous for loop
            foreach (var i in numbers)
            {
                Console.WriteLine(i);
            }

            // declaration of a string integer array

            string[] names = new string[3] { "Vancho", "Jason", "John" };

            // loop through the string array
            for (var i = 0; i < names.Length;i++)
            {
                Console.WriteLine($"Print names from array: {names[i]}");
            }

            Console.WriteLine();

            // foreach usage
            foreach (var i in names)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();

            // char
            char[] something = { 'S', 'o', 'm', 'e', 't', 'h', 'i', 'n', 'g' };
            for (int i = 0; i < something.Length; i++)
                Console.Write(something[i]);

            Console.WriteLine();

            // let's introduce foreach which does the same as the previous for loop
            foreach (var i in names)
            {
                if (i.Contains("Vancho"))
                    Console.WriteLine($"Yes exists in array!");

                Console.WriteLine($"Print names from array: {i}");
            }

            Console.WriteLine();

            // we don't have to initialize the array
            double[] myNumbers = { 0.5, 1.2, 2.5, 3.2, 4.6, 5.4 };
            Console.WriteLine(myNumbers[1]);

            // arithmetic operations with array
            Console.WriteLine(myNumbers[0] + myNumbers[1]); // Outputs 1.7

            Console.WriteLine();

            double sum = 0;
            // sum all values in double array
            for (int i = 0; i < myNumbers.Length; i++)
            {
                sum += myNumbers[i];
                Console.WriteLine("The sum of the array is: {0}",sum);
            }
        }
    }
}
