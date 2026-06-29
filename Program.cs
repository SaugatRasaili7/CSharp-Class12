using System;
 public class Program
{
public static void Main(string[] args)
    {
       /* string name;
        int rollNo;
        string email;
        */

        Console.WriteLine("Enter Your Name :");
        string Name = Convert.ToString(Console.ReadLine());

         Console.WriteLine("Enter Your RollNo :");
        int RollNo = Convert.ToInt32(Console.ReadLine());

         Console.WriteLine("Enter Your Email Address :");
        string Email = Convert.ToString(Console.ReadLine());



        // The Details are :

        Console.WriteLine("Your Name is :"+Name);

        Console.WriteLine("Your RollNo is :"+RollNo);

        Console.WriteLine("Your Email Address is :"+Email);
     

    }
}
