//Store the price and quantity of three products and calculate the total bill.
public class Program11
{
    public void Bill()
    {
        
        Console.WriteLine("--- Program to calculate total bill of three products ---");

        Console.WriteLine(" Enter the price of first product :");
        int price1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(" Enter the Quantity of the first product :");
        int quantity1 = Convert.ToInt32(Console.ReadLine());

        // Total of first product 

        int total1 = price1 * quantity1;


        Console.WriteLine(" Enter the price of second product :");
        int price2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(" Enter the Quantity of the second product :");
        int quantity2 = Convert.ToInt32(Console.ReadLine());

         // Total of second product 

           int total2 = price2 * quantity2;

         
        Console.WriteLine(" Enter the price of third product :");
        int price3 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(" Enter the Quantity of the third product :");
        int quantity3 = Convert.ToInt32(Console.ReadLine());

        
         // Total of third product 

           int total3 = price3 * quantity3;



           int totalBill = total1 + total2 + total3;

           Console.WriteLine($"The Total bill of three products is : {totalBill}");

    }
}