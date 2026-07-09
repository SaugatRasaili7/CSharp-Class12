// Program to Add Two Integer numbers
using System;

public class Program2
{

    public void GetInput(){

    Console.WriteLine("Enter the first Number :");
    int num1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter the Second Number :");
    int num2 = Convert.ToInt32(Console.ReadLine());

      int sum = num1 + num2;


        Console.WriteLine($"The Sum of {num1} and {num2} is : {sum}");
    }

}