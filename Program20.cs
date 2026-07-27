//Input two integers and display the larger one.
using System;
public class Program20{

    public void larger()
    {
        Console.WriteLine("--- Program to find out which one is larger ---");

        Console.WriteLine("Enter the first number :");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the Second number :");
        int num2 = Convert.ToInt32(Console.ReadLine());

        if (num1 > num2)
        {
            Console.WriteLine($"The number {num1} is greater");
        }

        else
        {
            Console.WriteLine($"The number {num2} is greater");
        }


    }
}