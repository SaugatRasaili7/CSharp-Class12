using System;
public class Question5
{
   
    public void employee()
{
    double salary;
    double bonus;
    double totalsalary;

    for (int i = 1; i <= 8; i++)
    {
        Console.WriteLine("Enter the salary of Employee");
        salary = Convert.ToDouble(Console.ReadLine());

        if (salary < 20000)
        {
            bonus = salary * 0.20;
        }
        else if (salary < 40000)
        {
            bonus = salary * 0.15;
        }
        else if (salary < 60000)
        {
            bonus = salary * 0.10;
        }
        else
        {
            bonus = salary * 0.05;
        }

        totalsalary = bonus + salary;

        Console.WriteLine($"Employee {i} Details:");
        Console.WriteLine($"The Salary is: {salary}");
        Console.WriteLine($"The bonus is: {bonus}");
        Console.WriteLine($"Total Salary is: {totalsalary}");
    }
}

}