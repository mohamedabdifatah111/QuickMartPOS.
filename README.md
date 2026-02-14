QuickMart POS System (Kenya)

A C# .NET console application built for QuickMart Supermarket in Nairobi to handle VAT-compliant sales and KRA transaction logging.

Features

VAT Classification: Categorizes products into Standard (16%), Zero-rated (0%), and Exempt (No VAT).

Automated Math: Computes VAT per item and generates a total VAT-inclusive receipt.

Compliance Logging: Automatically logs every transaction to sales_log.txt for KRA tax records.

Project Structure

Product.cs: Stores name, price, and tax category.

Receipt.cs: Handles the logic for printing receipts and writing to the log file.

VatRates.cs: Contains the global tax rates for easy updates.

Program.cs: The entry point where the sale is simulated.

How to Run

Open the project in Visual Studio.

Press F5 to run the console application.

Check the project folder for sales_log.txt to view the recorded transactions.
