using System;
public class Array4
{
    public void DecimalArray()
    {
        
        double[] num = new double[5];
        Console.WriteLine("Enter Five Number:");

        for(int i =0; i<num.Length; i++)
        {
            Console.WriteLine($"Enter the {i+1} number: ");
            num[i] = Convert.ToDouble(Console.ReadLine());

        }

        Console.WriteLine("The Entered number are :");

          for(int i =0; i<num.Length; i++)
        {
            Console.WriteLine($"The num {i+1}: {num[i]}");
            
        }

    }
}