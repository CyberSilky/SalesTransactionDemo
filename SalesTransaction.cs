using System;
using static System.Console;
using SalesTransactionDemo;
using SalesTransactionLibrary;

//Name: James Shoemaker
//Date: 04/19/2020
//Program Description: Module 5 assignment

namespace SalesTransactionDemo
{
    class SalesTransaction
    {
        static void Main(string[] args)
        {
            double total;
            Sales sale1 = new Sales();

            Write("Please enter the salesperson's name: ");
            sale1.SalesPersonName = ReadLine();

            Write("Please enter the sale amount:$ ");
            sale1.SalesAmount = double.Parse(ReadLine());

            Write("Please enter the commission amount:$ ");
            total = double.Parse(ReadLine());

            Write("Please enter the commision rate in decimal form: ");
            sale1.CommissionRate = double.Parse(ReadLine());

            WriteLine("Please review your information.....");
            WriteLine(sale1.PrintEmployeeInformation());

            WriteLine($"Your pay will be: {sale1.CommissionAmount().ToString("C")}");


        }
    }
}
