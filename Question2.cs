using System;

namespace ConsoleApplication2
{
    class Question2
    {
        static void Main(string[] args)
        {
            int amount;
            int discountPercentage;
            int discountAmount;
            int finalAmount;


            //We have to enter the purchase amount (Digits)
            Console.WriteLine("Enter Purchase Amount");
            amount = Convert.ToInt32(Console.ReadLine());


            //We have to check the amount for discount percentage
            if (amount >= 5000)
            {
                discountPercentage = 20;
            }
            else if (amount >= 2000 && amount < 5000)
            {
                discountPercentage = 10;
            }
            else
            {
                discountPercentage = 0;
            }


            //We have to calculate the discount amount and final payable amount
            discountAmount = (amount * discountPercentage) / 100;
            finalAmount = amount - discountAmount;


            //We have to print the final results
            Console.WriteLine("The discount percentage: " + discountPercentage + "%");
            Console.WriteLine("The discount amount: " + discountAmount);
            Console.WriteLine("The final payable amount: " + finalAmount);
        }
    }
}