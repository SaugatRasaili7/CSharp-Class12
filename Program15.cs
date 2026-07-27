//Create variables for hours, minutes, and seconds, then convert everything into total seconds.
using System;
public class Program15
{
    public void Converter()
    {
        Console.WriteLine("---- Program to convert hours , minutes , and seconds into second and total it. ----");

        Console.WriteLine("Enter the time in hours :");
        double hours = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the time in minutes :");
        double minutes = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the time in seconds :");
        double second = Convert.ToDouble(Console.ReadLine());
        
        hours = hours * 60 * 60;
        minutes = minutes * 60;

        double totalSecond = hours + minutes + second;

        Console.WriteLine($"The Total Time in Seconds is : {totalSecond}");
        


    }
    
}