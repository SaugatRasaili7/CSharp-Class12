using System;
public class JaggedArray1
{
    public void JaggedOne()
    {
        int [][] num = new int[2][];
        num[0] = new int[]{5,9,4,3};
        num[1] = new int[]{2,4,6,7,3,8};

        for(int i = 0; i<num.Length; i++)
        {
            for(int j=0; j<num[i].Length; j++)
            {
                Console.WriteLine(num[i][j] + " ");
            }
            Console.WriteLine();
        }
    }
    
}