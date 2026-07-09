// Declare variables for principal, rate, and time, then calculate simple interest.
using System;
public class Program8
{
    
  public void Interest()
    {
        Console.WriteLine("---Enter the details below to find out Simple Interest ----");


        Console.WriteLine("Enter the principal : ");
        double principal = Convert.ToDouble(Console.ReadLine());


        Console.WriteLine("Enter the Rate : ");
        double rate = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("Enter the Time in years: ");
        double time = Convert.ToDouble(Console.ReadLine());
        

        double SI = (principal * time * rate )/100;

        Console.WriteLine($"The Calculated Simple Interest is : {SI}");
    }

}