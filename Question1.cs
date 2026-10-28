using System;

namespace Question1
{
    class Question1
    {
        static void Main(string[] args)
        {
            int day;


            //We have to enter the day number (1 to 7)
            Console.WriteLine("Enter Day Number (1-7)");
            day = Convert.ToInt32(Console.ReadLine());


            //We have to check the day number and print day name
            if (day == 1)
            {
                Console.WriteLine("Monday");
            }
            else if (day == 2)
            {
                Console.WriteLine("Tuesday");
            }
            else if (day == 3)
            {
                Console.WriteLine("Wednesday");
            }
            else if (day == 4)
            {
                Console.WriteLine("Thursday");
            }
            else if (day == 5)
            {
                Console.WriteLine("Friday");
            }
            else if (day == 6)
            {
                Console.WriteLine("Saturday");
            }
            else if (day == 7)
            {
                Console.WriteLine("Sunday");
            }

            //If the number is not between 1 and 7
            else
            {   
                Console.WriteLine("Invalid number");
            }
        }
    }
}