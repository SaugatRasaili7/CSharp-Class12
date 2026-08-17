using System;
public class Question6
{
    public void student()
    {
        double marks;
        string name;
        string grade;

      for(int i=1; i<=4; i++)
        {
            Console.WriteLine("Enter the Name of the Student :");
            name = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter the Exam Score :");
            marks = Convert.ToDouble(Console.ReadLine());

            if(marks >= 90 && marks <= 100)
            {
                grade = "A";
            }

        }
    }
}