//Store the price and quantity of three products and calculate the total bill.
public class Program11
{
    public void Bill()
    {
        
        Console.WriteLine("--- Program to calculate total bill of three products ---");

        Console.WriteLine(" Enter the price of first product :");
        int Price1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(" Enter the Quantity of the first product :");
        int Quantity1 = Convert.ToInt32(Console.ReadLine());

        // Total of first product 

        int Total1 = Price1 * Quantity1;


        Console.WriteLine(" Enter the price of second product :");
        int Price2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(" Enter the Quantity of the second product :");
        int Quantity2 = Convert.ToInt32(Console.ReadLine());

         // Total of second product 

           int Total2 = Price2 * Quantity2;

         
        Console.WriteLine(" Enter the price of third product :");
        int Price3 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(" Enter the Quantity of the third product :");
        int Quantity3 = Convert.ToInt32(Console.ReadLine());

        
         // Total of third product 

           int Total3 = Price3 * Quantity3;



           int TotalBill = Total1 + Total2 + Total3;

           Console.WriteLine($"The Total bill of three products is : {TotalBill}");

    }
}