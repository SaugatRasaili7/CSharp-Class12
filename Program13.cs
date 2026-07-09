//Store a student's information (Name, Roll No, Faculty, GPA) and display it in a formatted report.
using System;
public class Program13
{
    
    public void Information()
    {
         Console.WriteLine("--- Program to Display Student Information ---");

            
        Console.WriteLine(" Enter the Name of the Student:");
        string studentName = Convert.ToString(Console.ReadLine());

        Console.WriteLine(" Enter the RollNo of the Student:");
        int rollNo = Convert.ToInt32(Console.ReadLine());

         Console.WriteLine(" Enter the Faculty of the Student:");
        string faculty = Convert.ToString(Console.ReadLine());

        Console.WriteLine("Enter the Grade Point Average(GPA) of the Student");
        double GPA = Convert.ToDouble(Console.ReadLine());
    

        Console.WriteLine("===== Student Report =====");
        Console.WriteLine($"Name     : {studentName}");
        Console.WriteLine($"Roll No  : {rollNo}");
        Console.WriteLine($"Faculty  : {faculty}");
        Console.WriteLine($"GPA      : {GPA}");
        Console.WriteLine("==========================");






    }
}