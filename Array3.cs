using System;
public class Array3
{
    public void StringArray()
    {
        
        string[] name = new string[5];
        Console.WriteLine("Enter Five Name:");

        for(int i =0; i<name.Length; i++)
        {
            Console.WriteLine($"Enter the {i+1} name: ");
            name[i] = Convert.ToString(Console.ReadLine());

        }

        Console.WriteLine("The Entered names are :");

          for(int i =0; i<name.Length; i++)
        {
            Console.WriteLine($"The name {i+1}: {name[i]}");
            
        }

    }
}