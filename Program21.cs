//Write a program to find the smaller of two numbers.
using System;
public class Program21
{
    public void smaller()
    {
        Console.WriteLine("--- Program to find out which one is smaller ---");

        Console.WriteLine("Enter the first number :");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the Second number :");
        int num2 = Convert.ToInt32(Console.ReadLine());

        if (num1 < num2)
        {
            Console.WriteLine($"The number {num1} is smaller");
        }

        else
        {
            Console.WriteLine($"The number {num2} is smaller");
        }
    }
}