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
        string name = Convert.ToString(Console.ReadLine());

         Console.WriteLine("Enter Your RollNo :");
        int rollNo = Convert.ToInt32(Console.ReadLine());

         Console.WriteLine("Enter Your Email Address :");
        string email = Convert.ToString(Console.ReadLine());



        // The Details are :

        Console.WriteLine("Your Name is :"+name);

        Console.WriteLine("Your RollNo is :"+rollNo);

        Console.WriteLine("Your Email Address is :"+email);
     

    }
}
