//Create variables for five subject marks and calculate the average.
using System;
public class Program9
{
    
    public void Average()
    {
        Console.WriteLine("----- There are Five Subjects (Maths,Chemistry,Physics,English,Nepali) -----");

        Console.WriteLine("Enter the Marks of Mathematics :");
        double Mathematics = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the Marks of Chemistry :");
        double Chemistry = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the Marks of Physics :");
        double Physics = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the Marks of English :");
        double English = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the Marks of Nepali :");
        double Nepali = Convert.ToDouble(Console.ReadLine());

        Double Average = (Mathematics + Chemistry + Physics + English + Nepali )/5;

        Console.WriteLine($"The Average marks of Five Subjects is : {Average}");
        
    }
}