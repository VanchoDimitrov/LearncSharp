using System;

namespace _7UserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            // USER INPUT
            string name;
            int age;
            decimal salary;
            string profession;

            Console.WriteLine("How much are you earning per year!");
            Console.WriteLine("**********************************");

            // Name
            Console.Write("Enter name please: ");
            name = Console.ReadLine();

            // enter the age
            Console.Write("Enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());

            // enter the salary
            Console.Write("Enter salary: ");
            salary = Convert.ToDecimal(Console.ReadLine());

            // enter profession
            Console.WriteLine("Enter profession: ");
            profession = Console.ReadLine();

            // Output
            Console.WriteLine($"{name} is {age} old person with a salary of {salary}" +
                $" and profession {profession}");


            bool isEmployeeStillWorking;
            Console.Write("Please type in true/false if the employee is working with us! ");
            isEmployeeStillWorking = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("The employee is working: {0}", isEmployeeStillWorking);



            // MORE ON STRINGS


            // integer input by user
            //int age; //declare variable age of a type integer​
            Console.Write("How old are you? ");

            // read the user input and convert it to an integer.
            //If user enters a string value the compiler will throw an exception or an error.​
            age = Convert.ToInt32(Console.ReadLine());

            // print the age value and before you do that convert it to string​
            Console.WriteLine("You are {0} old.", age.ToString());

            Console.WriteLine();

            // string input by user
            //string name;
            Console.Write("Please enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine($"Your name is: {name}");

            Console.WriteLine();
            
            // bool input by user
            bool isItActive;
            Console.Write("Is this user active? ");
            isItActive = Convert.ToBoolean(Console.ReadLine());

            if (isItActive)
            {
                Console.WriteLine("The user is active");
            }
            else
            {
                Console.WriteLine("The user is not active!");
            }

            Console.WriteLine();

            // char input by user
            char d;
            Console.Write("Delete file y/n");
            d = Convert.ToChar( Console.ReadLine());

            if(d == 'y')
            {
                Console.WriteLine("File has been deleted from your system.");
            }
            else if (d == 'n')
            {
                Console.WriteLine("The file has not been deleted from the system.");
            }
            else
            {
                Console.WriteLine("Wrong entry! Try again please.");
            }
        }
    }
}