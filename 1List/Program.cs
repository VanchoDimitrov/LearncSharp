using System;
using System.Collections.Generic;

namespace _1List
{
    class Program
    {
        static void Main(string[] args)
        {
            // List of a type string
            List<string> towns = new List<string>()
            {
                "Berlin",
                "Tokio",
                "London"
            };

            towns.Add("New York");
            towns.Remove("Tokio");

            // print value by index
            Console.WriteLine(towns[0]);

            // count towns in List
            Console.WriteLine(towns.Count);

            // find index of Tokio
            Console.WriteLine(towns.IndexOf("Tokio"));


            // sort towns alphabetically before printing on screen
            towns.Sort();

            // let's loop through the loop
            for (int i = 0; i < towns.Count; i++)
            {
                Console.WriteLine($"Name of town: {towns[i]}");
            }

            Console.WriteLine();

            // foreach variant
            foreach (var i in towns)
            {
                Console.WriteLine($"Name of town: {i}");
            }

            // List of a type integer
            List<int> grades = new List<int>()
            {
                1,2,3,4,5
            };

            grades.Add(6);
            grades.Remove(5);

            // print value by index
            Console.WriteLine(grades[0]);

            // count towns in List
            Console.WriteLine(grades.Count);

            // find index of Tokio
            Console.WriteLine(grades.IndexOf(1));


            // sort towns alphabetically before printing on screen
            grades.Sort();

            // sort in reverse
            //grades.Reverse()

            // let's loop through the loop
            for (int i = 0; i < grades.Count; i++)
            {
                Console.WriteLine($"Grade: {grades[i]}");
            }

            Console.WriteLine();

            // foreach variant
            foreach (var i in grades)
            {
                Console.WriteLine($"Grade: {i}");
            }


            // List of a type boolean
            List<bool> activeOrNot = new List<bool>()
            {
                true,false
            };

            activeOrNot.Add(false);

            // print value by index
            Console.WriteLine(activeOrNot[0]);

            // count towns in List
            Console.WriteLine(activeOrNot.Count);

            // sort towns alphabetically before printing on screen
            activeOrNot.Sort();

            // sort in reverse
            //grades.Reverse()

            // let's loop through the loop
            for (int i = 0; i < activeOrNot.Count; i++)
            {
                Console.WriteLine($"Active or Not: {activeOrNot[i]}");
            }

            Console.WriteLine();

            // foreach variant
            foreach (var i in activeOrNot)
            {
                Console.WriteLine($"Active or Not: {i}");
            }
        }
    }
}
