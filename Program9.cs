//Create variables for five subject marks and calculate the average.
using System;
public class Program9
{
    
    public void Average()
    {
        Console.WriteLine("----- There are Five Subjects (Maths,Chemistry,Physics,English,Nepali) -----");

        Console.WriteLine("Enter the Marks of Mathematics :");
        double mathematics = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the Marks of Chemistry :");
        double chemistry = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the Marks of Physics :");
        double physics = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the Marks of English :");
        double english = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the Marks of Nepali :");
        double nepali = Convert.ToDouble(Console.ReadLine());

        Double average = (mathematics + chemistry + physics + english + nepali )/5;

        Console.WriteLine($"The Average marks of Five Subjects is : {average}");
        
    }
}