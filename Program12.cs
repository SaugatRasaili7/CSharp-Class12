//Declare variables for employee name, basic salary, bonus, and tax, then calculate the net salary.
using System;
public class Program12
{
    public void Employee()
    {
        Console.WriteLine("--- Program to Calculate salary of an employee---");

        
        Console.WriteLine(" Enter the Name of the Employee:");
        string EmployeeName = Convert.ToString(Console.ReadLine());


        
        Console.WriteLine(" Enter the Salary of the Employee:");
        double EmployeeSalary = Convert.ToDouble(Console.ReadLine());

          Console.WriteLine(" Enter the Bonus of the Employee:");
        double EmployeeBonus = Convert.ToDouble(Console.ReadLine());


          Console.WriteLine(" Enter the tax that is needed to be paid by Employee:");
        double EmployeeTax = Convert.ToDouble(Console.ReadLine());

        double TaxAmount = EmployeeSalary - ((EmployeeTax / 100) * EmployeeSalary);

        double TotalSalary = TaxAmount + EmployeeBonus;

        Console.WriteLine($" The total salary of Employee {EmployeeName} is {TotalSalary}");


    }
}