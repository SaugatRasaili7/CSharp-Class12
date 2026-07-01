//Swap the values of two variables using a third variable.

public class Program5
{
    public void Swap()
    {
        Console.WriteLine("Enter the value of first Variable :");
        int Variable1 = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Enter the value of Second Variable :");
        int Variable2 = Convert.ToInt32(Console.ReadLine());

        int Variable3 = Variable1;
        Variable1 = Variable2;
        Variable2 = Variable3;

        Console.WriteLine($"The value of first variable is {Variable1} and Second Variable is {Variable2}");

    }
}