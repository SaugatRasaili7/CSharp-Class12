//Store the temperature in Celsius and convert it to Fahrenheit.
using System;
public class Program10
{
    public void Temperature()
    {
        Console.WriteLine("---- Program to convert temperature given in celsius to fahrenheit ----");

        Console.WriteLine("Enter the temperature in celsius to convert it into fahrenheit :");
        double celsius = Convert.ToDouble(Console.ReadLine());

        double fahrenheit = ((9*celsius)/5)+ 32;

        Console.WriteLine($"The Temperature given in Celsius {celsius} is {fahrenheit} in Fahrenheit");
        
            }
}