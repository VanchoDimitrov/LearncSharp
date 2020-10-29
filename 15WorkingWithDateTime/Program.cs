using System;

namespace _15WorkingWithDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define date variable
            DateTime customDate = new DateTime(2020, 09, 24);

            // print custom date
            Console.WriteLine(customDate.ToShortDateString());

            // Add month
            var withAddedMonth = customDate.AddMonths(1);
            Console.WriteLine(withAddedMonth.ToShortDateString());

            // prints custom date with added day
            var withAddedDay = customDate.AddDays(1);
            Console.WriteLine(withAddedDay.ToShortDateString());

            // prints today's date and time
            Console.WriteLine(DateTime.Today.ToShortDateString());

            // prints yesterday's date
            var yesterday = DateTime.Today;
            Console.WriteLine($"Yesterday: {yesterday.AddDays(-1)}");


            // string to datetime
            string date = "9/24/2020";

            // convert from string to date
            var newDate = Convert.ToDateTime(date);
            Console.WriteLine(newDate.ToShortDateString());

            // print out only the month
            Console.Write("Month of: {0}",newDate.Month + " or ");

            // print out only the day
            Console.WriteLine("Day: {0}", newDate.Day);

            // print out only the year
            Console.WriteLine("Year: {0}", newDate.Year);


            // some logic
            if (newDate.Month == 9)
                Console.Write("the Month of September");

            Console.WriteLine();

            // check how many days are in a given month
            int sumDays = DateTime.DaysInMonth(2020, 9);
            Console.WriteLine($"September has {sumDays} days!");

        }
    }
}
