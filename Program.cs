
using System;

class Program
{
    static void Main()
    {
        // 1. Setup inventory
        var milk = new Product("Milk", 60.00m, VatCategory.ZeroRated);
        var tv = new Product("Smart TV", 35000.00m, VatCategory.Standard);
        var mask = new Product("Medical Mask", 20.00m, VatCategory.Exempt);

        // 2. Start a new transaction
        var receipt = new Receipt();

        // 3. Customer buys items
        receipt.AddItem(new SaleItem(tv, 1));
        receipt.AddItem(new SaleItem(milk, 2));
        receipt.AddItem(new SaleItem(mask, 5));

        // 4. Finalize and log for KRA
        receipt.PrintReceipt();

        Console.WriteLine("\nTransaction complete. Press any key to exit.");
        Console.ReadKey();
    }
}