using System;

namespace ConsoleApplication4
{
    class Question4
    {
        static void Main(string[] args)
        {   
            int a, b, sum, sub, mul, div;
            string sign;

            //We have to type the first number
            Console.WriteLine("Enter First Number");
            a = Convert.ToInt32(Console.ReadLine());

            //We have to type the Second number
            Console.WriteLine("Enter Second Number");
            b = Convert.ToInt32(Console.ReadLine());

            //now we use arthmetic operations to perform a calculations
            Console.WriteLine("Enter Sign (+, -, *, /)");
            sign = Console.ReadLine();

            //this (if) is used for the addition operation whenever we wants to add the numbers
            if (sign == "+")
            {
                sum = a + b;
                Console.WriteLine("Addition is:" + sum);
            }

            //this (else if) is used for the subtraction operation whenever we want to subtract the numbers
            else if (sign == "-")
            {
                sub = a - b;
                Console.WriteLine("Subtraction is:" + sub);
            }

            //this (else if) is used for the multiplication operation whenever we want to multiply the numbers
            else if (sign == "*")
            {
                mul = a * b;
                Console.WriteLine("Multiplication is:" + mul);
            }

            //this (else if) is used for the division operation whenever we want to divide the numbers
            else if (sign == "/")
            {
                div = a / b;
                Console.WriteLine("Division is:" + div);
            }

            //this (else) is used when we input the invalid sign or number
            else
            {
                Console.WriteLine("Invalid sign or Number");
            }
        }    
    }
}