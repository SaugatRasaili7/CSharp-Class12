using System;
public class Array2
{
    public void TwoArray()
    {
        int[,] num = new int[2,3];

        Console.WriteLine("Enter the numbers:");
        for(int i=0; i<=1; i++){
            for(int j=0; j<=2; j++)
            {
                Console.WriteLine($"Enter the value of {i}{j} element");
                num[i,j] = Convert.ToInt32(Console.ReadLine());

            }

            Console.WriteLine("");
        }


        for(int i=0; i<=1; i++){
            for(int j=0; j<=2; j++)
            {
                Console.Write(num[i,j]+ " ");

            }

            Console.WriteLine("");
        }


    }
}