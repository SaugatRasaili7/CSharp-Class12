//Store the dimensions of a room and calculate its volume.
using System;
public class Program16
{
    public void Volume()
    {
        Console.WriteLine("---- Program to find the volume of any room ----");

        Console.WriteLine("Enter the Length :");
        double length = Convert.ToDouble(Console.ReadLine());


        Console.WriteLine("Enter the Breadth :");
        double breadth = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the Height :");
        double height = Convert.ToDouble(Console.ReadLine());

        double volume = length * breadth * height;

        Console.WriteLine($"The calculated volume is : {volume}");
        
        
        
    }
    
}