//Calculate compound interest using variables.
using System;
public class Program14
{
    public void CompoundInterest()
    {
        Console.WriteLine("---- Program to find the Compound Interest ----");

        bool value = true;
        
        while(value){
        Console.WriteLine("There are types of Compound Interest");

        Console.WriteLine("1. Yearly Compound Interest");
        Console.WriteLine("2. Half-Yearly Compound Interest");
        Console.WriteLine("3. Quartly Compound Interest");
        Console.WriteLine("4. Terminate Program");
        

        Console.WriteLine("Enter Your Choice :");
        int choice = Convert.ToInt32(Console.ReadLine());

        if(choice == 1)
        {
            Console.WriteLine("Enter the Principal :");
            double principal1 = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Enter the Rate :");
            double rate1 = Convert.ToDouble(Console.ReadLine());
            

            Console.WriteLine("Enter the Time :");
            double time1 = Convert.ToDouble(Console.ReadLine());


            double compoundInterest1 = principal1 * (Math.Pow(1+rate1/100 , time1) - 1);

            Console.WriteLine($"The Yearly Compound Interest calculated is : {compoundInterest1}");
            
        }


        else if(choice == 2)
        {
            
          
    
            Console.WriteLine("Enter the Principal :");
            double principal2 = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Enter the Rate :");
            double rate2 = Convert.ToDouble(Console.ReadLine());
            

            Console.WriteLine("Enter the Time :");
            double time2 = Convert.ToDouble(Console.ReadLine());


            double compoundInterest2 = principal2 * (Math.Pow(1+rate2/200 , 2*time2) - 1);

            Console.WriteLine($"The Half-Yearly Compound Interest calculated is : {compoundInterest2}");
            
        }


        
        else if(choice == 3)
        {
            
          
    
            Console.WriteLine("Enter the Principal :");
            double principal3 = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Enter the Rate :");
            double rate3 = Convert.ToDouble(Console.ReadLine());
            

            Console.WriteLine("Enter the Time :");
            double time3 = Convert.ToDouble(Console.ReadLine());


            double compoundInterest3 = principal3 * (Math.Pow(1+rate3/200 , 2*time3) - 1);

            Console.WriteLine($"The Half-Yearly Compound Interest calculated is : {compoundInterest3}");
            
    

        }

        else if(choice == 4)
        {
            value = false;
            Console.WriteLine("Program Terminated Successfully,Goodbye....");
        }


        }

    }
}