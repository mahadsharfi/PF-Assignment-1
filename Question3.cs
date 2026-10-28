using System;

namespace ConsoleApplication3
{
    class Question3
    {
        static void Main(string[] args)
        {   
            int year;

            //We have to enter the year (Digits)
            Console.WriteLine("Enter Year");
            year = Convert.ToInt32(Console.ReadLine());


            //We have to check if the year is a leap year or not
            if (year % 400 == 0)
            {
                Console.WriteLine("leap year");
            }
            else if (year % 100 == 0)
            {
                Console.WriteLine("not a leap year");
            }
            else if (year % 4 == 0)
            {
                Console.WriteLine("leap year");
            }
            else
            {
                Console.WriteLine("not a leap year");
            }
        }
    }
}