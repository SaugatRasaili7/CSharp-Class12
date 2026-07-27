//Declare variables for employee name, basic salary, bonus, and tax, then calculate the net salary.
using System;
public class Program12
{
    public void Employee()
    {
        Console.WriteLine("--- Program to Calculate salary of an employee---");

        
        Console.WriteLine(" Enter the Name of the Employee:");
        string employeeName = Convert.ToString(Console.ReadLine());


        
        Console.WriteLine(" Enter the Salary of the Employee:");
        double employeeSalary = Convert.ToDouble(Console.ReadLine());

          Console.WriteLine(" Enter the Bonus of the Employee:");
        double employeeBonus = Convert.ToDouble(Console.ReadLine());


          Console.WriteLine(" Enter the tax that is needed to be paid by Employee:");
        double employeeTax = Convert.ToDouble(Console.ReadLine());

        double taxAmount = employeeSalary - ((employeeTax / 100) * employeeSalary);

        double totalSalary = taxAmount + employeeBonus;

        Console.WriteLine($" The total salary of Employee {employeeName} is {totalSalary}");


    }
}