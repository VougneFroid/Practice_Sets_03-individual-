using System;
namespace Leap_Year
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to leap year identifier!\n");

            Console.Write("Enter a year: ");
            int year = Convert.ToInt32(Console.ReadLine());
            bool isLeapYear = IsLeapYear(year);
            if (isLeapYear)
            {
                Console.WriteLine($"The year {year} is a leap year.");
            }
            else
            {
                Console.WriteLine($"The year {year} is not a leap year.");
            }
        }

        static bool IsLeapYear(int year)
        {
            if ((year % 4 == 0 && year % 100 != 0) || (year % 4 == 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
