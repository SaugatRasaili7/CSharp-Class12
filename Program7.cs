//Store the length and breadth of a rectangle and calculate the perimeter.
using System;

public class Program7
{
    
    public void Perimeter()
    {
        Console.WriteLine("Enter the Length of the Rectangle :");
        double Length = Convert.ToDouble(Console.ReadLine());


        Console.WriteLine("Enter the Breadth of the Rectangle :");
        double Breadth = Convert.ToDouble(Console.ReadLine());

        double Perimeter = 2*(Length + Breadth);

        Console.WriteLine($"The perimeter of the Rectangle is : {Perimeter}");

        
        
    }

    
}