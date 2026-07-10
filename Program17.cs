//Create variables to calculate electricity bills based on consumed units.
using System;
public class Program17
{
    public void electricityBill()
    {
        Console.WriteLine("--- Program to find the electricity consumed bill ---");

        Console.WriteLine("Enter the Consumed unit :");
        int unit = Convert.ToInt32(Console.ReadLine());
        

        if(unit>=0 && unit <= 20)
        {
            double bill1 = (unit * 3) + 30;
            Console.WriteLine($"The Total Bill of Electricity Consumed is : {bill1}");
        }
        
        else if(unit>20 && unit <= 30)
        {
            double bill2 = (unit * 6.50) + 50;
            Console.WriteLine($"The Total Bill of Electricity Consumed is : {bill2}");
            
        }

        else if(unit>30 && unit <= 50)
        {
            double bill3 = (unit * 8) + 50;
            Console.WriteLine($"The Total Bill of Electricity Consumed is : {bill3}");
            
        }

        else if(unit>50 && unit <= 150)
        {
            double bill4 = (unit * 9.50) + 75;
            Console.WriteLine($"The Total Bill of Electricity Consumed is : {bill4}");
        }
        
        else if(unit > 150)
        {
            double bill5 = (unit * 12) + 75;
            Console.WriteLine($"The Total Bill of Electricity Consumed is : {bill5}");



            
        }








    }
}