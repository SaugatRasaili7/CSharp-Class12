using System;
public class JaggedArray2
{
    public void JaggedTwo()
    {
        int [][,] num = new int[2][,]
        {
            new int[,]
            {
                {2,4,6,8},
                {1,3,5,7}
            },

            new int[,]
            {
                {9,7,3},
                {8,5,2}
            }
        };
        

        for(int i = 0; i<num.Length; i++)
        {
            for(int j=0; j<num[i].GetLength(0); j++)
            {
                for(int k =0; k<num[i].GetLength(1); k++)
                {
                    
                    Console.Write(num[i][j,k] +" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            
        }
    }
    
}