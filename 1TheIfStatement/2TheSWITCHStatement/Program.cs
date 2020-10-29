using System;

namespace _2TheSWITCHStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*************");
            Console.WriteLine("1 - Open File");
            Console.WriteLine("2 - Save File");
            Console.WriteLine("*************");

            int choose;
            Console.Write("Choose an option from the menu: ");
            choose = Convert.ToInt32(Console.ReadLine());

            switch (choose)
            {
                case 1:
                    Console.WriteLine("Opening File");
                    break;
                case 2:
                    Console.WriteLine("Saving File");
                    break;
                default:
                    Console.WriteLine("Wrong Choice!");
                    break;
            }
        }
    }
}
