using System;

namespace MyConsoleApp
{
    public static class DateWeekAfter
    {
        internal static void dateFunction()
        {
            Console.WriteLine("Enter Date, example: 01-12-2020: ");
            string UserInput = Console.ReadLine();

            DateTime ShowDate(string input)
            {
                DateTime convertString = DateTime.Parse(input);
                DateTime DateWeekAfter = convertString.AddDays(7);
                Console.WriteLine("The date a week after is " + DateWeekAfter);
                return DateWeekAfter;
            }
            ShowDate(UserInput);
        }
    }
}
