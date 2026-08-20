using System;
using System.ComponentModel;
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
            else if(marks >= 80 && marks <= 89)
            {
                grade = "B";

            }

            else if(marks >= 70 && marks <= 79)
            {
                grade = "C";
            }

            else if(marks >= 60 && marks <=69)
            {
                grade = "D";
            }
      
            else
            {
                 grade = "F";
            }

            Console.WriteLine("---The Details of Student---");
            Console.WriteLine($"Student Name : {name}");
            Console.WriteLine($"Exam Score : {marks}");
            Console.WriteLine($"Final Grade : {grade}");

        }
    }
}