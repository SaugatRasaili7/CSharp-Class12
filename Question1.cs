// Decision Making Statement 
// Write a program to input a number and determine whether it is:

// * Positive
// * Negative
// * Zero

using System;
public class Question1
{
    public void decision()
    {
        Console.WriteLine("Enter the number to find whether it is positive , negative or zero :");
        int number = Convert.ToInt32(Console.ReadLine());

        if(number > 0)
        {
            Console.WriteLine($"The given number {number} is  positive ");
        }

        else if (number < 0)
        {
            Console.WriteLine($"The given number {number} is  Negative ");

        }

        else if(number == 0)
        {
            Console.WriteLine($"The given number {number} is  equal to zero ");
        }
    }
    
}