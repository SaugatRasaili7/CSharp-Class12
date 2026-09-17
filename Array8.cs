using System;
public class Array8{

    public void ArrayDimension()
    {
        string[,,] num = new string[2,3,2];
        Console.WriteLine("Enter the number :");
        
        for(int i= 0; i<=1; i++)
        {
            for(int j=0; j<=2; j++)
            {
                for(int k=0; k<=1; k++)
                {
                    Console.WriteLine($"Enter the {i}{j}{k} Element :");
                    num[i,j,k] = Convert.ToString(Console.ReadLine());

                }
                Console.WriteLine();
            }
            Console.WriteLine();

        }


             for(int i= 0; i<=1; i++)
        {
            for(int j=0; j<=2; j++)
            {
                for(int k=0; k<=1; k++)
                {
                    Console.Write(num[i,j,k] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }



        
    }
}