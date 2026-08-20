using System;
public class Question7
{
    public void app()
    {
        double sub1;
        double sub2;
        double sub3;
        double total;
        double percentage;

        for(int i =1; i<=5; i++)
        {
            Console.WriteLine($"Enter the marks of student {i} :");

            Console.WriteLine("Enter the Marks of VP :");
            sub1 = Convert.ToDouble(Console.ReadLine());

             Console.WriteLine("Enter the Marks of SEP :");
            sub2 = Convert.ToDouble(Console.ReadLine());

             Console.WriteLine("Enter the Marks of CN :");
            sub3 = Convert.ToDouble(Console.ReadLine());

            if(sub1>100 && sub2>100 && sub3 > 100)
            {
                Console.WriteLine("Please Enter marks in range between 0-100");
            }

            total = sub1 + sub2 + sub3;
            percentage = total/300 * 100;

            Console.WriteLine($"The Total marks Obtained by student {i} is {total}");
            Console.WriteLine($"The percentage is {percentage}");


        }
    }
}