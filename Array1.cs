using System;
public class Array1
{
    public void OneArray()
    {
        int[] num = new int[5];
        Console.WriteLine("Enter the numbers :");

        for(int i=0; i<=4; i++)
        {
            Console.WriteLine($"Enter the value of num[{i}]");
            num[i] = Convert.ToInt32(Console.ReadLine());
        }


        Console.WriteLine("The Entered Numbers are :");
        for(int i = 0; i<=4; i++)
        {
            Console.Write(num[i]+" ");
        }
    }
}