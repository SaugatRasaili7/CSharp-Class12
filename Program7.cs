//Store the length and breadth of a rectangle and calculate the perimeter.
using System;

public class Program7
{
    
    public void Perimeter()
    {
        Console.WriteLine("Enter the Length of the Rectangle :");
        double length = Convert.ToDouble(Console.ReadLine());


        Console.WriteLine("Enter the Breadth of the Rectangle :");
        double breadth = Convert.ToDouble(Console.ReadLine());

        double perimeter = 2*(length + breadth);

        Console.WriteLine($"The perimeter of the Rectangle is : {perimeter}");

        
        
    }

    
}