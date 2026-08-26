
//Create a function `MultiplicationTable()` with **no arguments and no return type**.
using System;
public class Method2
{
    public void MultiplicationTable()
    {

        Console.WriteLine("The Multiplication table of 5 is :");

        for(int i=1; i<=10; i++)
        {
            int  mult = 5 * i;
            Console.WriteLine($" 5 * {i} = {mult}");
        }
    }
}