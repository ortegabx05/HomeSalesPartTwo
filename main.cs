using System;

class Program 
{
    public static void Main(string[] args)
    {
        string[] salesPersonNames = {"Danielle", "Edward", "Francis"};
        char[] salesPersonInitials = {'D', 'E', 'F'};
        double[] salesValues = new double[3];

        double grandTotal = 0;
        char highestSalesPerson = ' ';
        double highestTotal = 0;

        while (true)
        {
          Console.WriteLine("Enter salesperson's initial or Z to exit: ");
          string initial = Console.ReadLine().ToUpper();

          if (initial == "Z")
        {
          break;
        }

          int i = Array.IndexOf(salesPersonInitials, initial[0]);

          if (i >= 0)
        {
          Console.WriteLine($"Enter the total amount for {salesPersonNames[i]}: ");
          double saleAmount;

          if (double.TryParse(Console.ReadLine(), out saleAmount))
        {
          salesValues[i] += saleAmount;
          grandTotal += saleAmount;

          if (saleAmount > highestTotal)
        {
          highestTotal = saleAmount;
          highestSalesPerson = initial[0];
        }
      }
    } 
          else
          {
            Console.WriteLine("Error, invalid salesperson selected. Please try again.");
          }
          
          }

            Console.WriteLine($"Grand Total: ${grandTotal}");
            Console.WriteLine($"Highest Sale: {highestSalesPerson}");
        }
 }

