//Store the radius of a circle in a variable and calculate the area.
  using System;

  public class Program4{
    public void Circle()
    {
     
     Console.WriteLine("Enter the Raduis of circle :");
     double radius = Convert.ToDouble(Console.ReadLine());

     double area = 3.14 * radius * radius;

     Console.WriteLine($"The Area of Circle is : {area}");
     

    }
  }