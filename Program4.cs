//Store the radius of a circle in a variable and calculate the area.
  using System;

  public class Program4{
    public void Circle()
    {
     
     Console.WriteLine("Enter the Raduis of circle :");
     double Radius = Convert.ToDouble(Console.ReadLine());

     double Area = 3.14 * Radius * Radius;

     Console.WriteLine($"The Area of Circle is : {Area}");
     

    }
  }