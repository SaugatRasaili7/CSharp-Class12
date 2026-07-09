//Swap the values of two variables using a third variable.

public class Program5
{
    public void Swap()
    {
        Console.WriteLine("Enter the value of first Variable :");
        int variable1 = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Enter the value of Second Variable :");
        int variable2 = Convert.ToInt32(Console.ReadLine());

        int variable3 = variable1;
        variable1 = variable2;
        variable2 = variable3;

        Console.WriteLine($"The value of first variable is {variable1} and Second Variable is {variable2}");

    }
}