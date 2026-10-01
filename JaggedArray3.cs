using System;

public class JaggedArray3
{
    public void JaggedThree()
    {
        int [][,,] num = new int[2][,,]
        {
            new int[,,]
            {
                {
                    {2,4,6},
                    {1,3,5}
                },
                {
                    {8,10,12},
                    {7,9,11}
                }
            },

            new int[,,]
            {
                {
                    {9,7,3},
                    {8,5,2}
                },
                {
                    {4,6,8},
                    {1,3,5}
                }
            }
        };

        for(int i = 0; i < num.Length; i++)
        {
            for(int j = 0; j < num[i].GetLength(0); j++)
            {
                for(int k = 0; k < num[i].GetLength(1); k++)
                {
                    for(int l = 0; l < num[i].GetLength(2); l++)
                    {
                        Console.Write(num[i][j,k,l] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}