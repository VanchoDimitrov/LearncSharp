using System;

namespace _5Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            // explicit - initialization is not mandatory
            int age;
            age = 20;

            // interpolation
            Console.WriteLine($"I am {age} years old person");

            decimal salary = 55.500M;
            Console.WriteLine("Salary is: {0}", salary);

            double costOfProduct = 20.456;
            Console.WriteLine($"Cost of product is: {costOfProduct}");

            string typeOfCourse = "Beginners Course in c#";
            Console.WriteLine("Type of course: {0}", typeOfCourse);

            bool isTakingSalary = true;
            Console.WriteLine("The employee is taking salary: {0}", isTakingSalary);

            // mulitiple value assignment on a variable
            age = 35;
            Console.WriteLine("I became older and now I am {0}", age);


            // implicit = initialization is a must
            var myAge = 40;
            Console.WriteLine($"I have became much older now {myAge}");

            // what happens when you attempt to print an empty or not assigned variable
            int price = 15;
            Console.WriteLine(price);
        }
    }
}
