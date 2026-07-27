// Program to Add the total marks of Physics,Chemistry,Mathematics
using System;

public class Program3
{

    public void CalculateMarks(){

    Console.WriteLine("Enter the Marks of Physics :");
    double physics = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Enter the Marks of Chemistry :");
    double chemistry = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Enter the Marks of Mathematics:");
    double mathematics = Convert.ToDouble(Console.ReadLine());

      double totalMarks = physics + chemistry + mathematics;



        Console.WriteLine($"The Total of Physics , Chemistry and Mathematics is : {totalMarks}");
    }

}