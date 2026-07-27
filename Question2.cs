//Write a C# program that checks whether a given integer is even or odd.
using System;
public class Question2
{
    public void checker()
    {
        Console.WriteLine("Enter the number to check whether a given number is Even or Odd :");
        int number = Convert.ToInt32(Console.ReadLine());

        if(number % 2 == 0)
        {
            Console.WriteLine($"The given number {number} is Even ");

        }
        else
        {
            Console.WriteLine($"The given number {number} is Odd ");
        }
    }
}