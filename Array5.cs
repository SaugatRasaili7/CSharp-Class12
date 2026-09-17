using System;
public class Array5
{
    public void TwoDArray()
    {
        double[,] numbers = new double[2,3];

        Console.WriteLine("Enter the numbers :");
        
        for(int i=0; i<=1; i++){
            for(int j=0; j<=2; j++)
            {
                Console.WriteLine("Enter Numbers:");
                numbers[i,j] = Convert.ToDouble(Console.ReadLine());

            }
        }


        for(int i=0; i<=1; i++){
            for(int j=0; j<=2; j++)
            {
                Console.Write(numbers[i,j]+" ");

            }

            Console.WriteLine("");
        }




    }
}