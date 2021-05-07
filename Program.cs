using System;
using System.Globalization;

namespace Class2Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            // Fahrenheit to celsius conversion
            //Console.WriteLine("Hello! Please enter the temperature in Fahrenheit");
            //double TempinFahrenheit = double.Parse(Console.ReadLine());
            //Double TempinCelsius = (TempinFahrenheit - 32) / 1.8;
            //Console.WriteLine("Celsius representation for {0} is {1}", TempinFahrenheit, TempinCelsius);

            // Product price calculation
            //Console.WriteLine("Hello! Please enter the price of the product");
            //double productPrice = double.Parse(Console.ReadLine());
            //Console.WriteLine("Hello! Please enter the tax in percentage");
            //double salestax = double.Parse(Console.ReadLine());
            //double Totalprice = productPrice + (productPrice * (salestax / 100));
            //Console.WriteLine("Price of the product including taxes is " + Totalprice);

            //Tip Calculator
            //Console.WriteLine("Hello! Please enter the total bill");
            //double billAmount = double.Parse(Console.ReadLine());
            //Console.WriteLine("Hello! Please enter the percentage of tip");
            //double tipAmount = double.Parse(Console.ReadLine());
            //double totalBill = billAmount + (billAmount * tipAmount / 100);
            //Console.WriteLine("Hello Customer! The amount you owe is {0}", totalBill);

            //Bill Dividend
            Console.WriteLine("Hello! Please enter the total bill");
            double billAmount = double.Parse(Console.ReadLine());
            Console.WriteLine("Hello! Please enter the no. of ppl sharing");
            double sharingperson = int.Parse(Console.ReadLine());
            double Amountperperson = billAmount / sharingperson;
            Console.WriteLine("Hello Customer! The amount each of you owe is {0}", Amountperperson);

            //Formatting money
            Console.WriteLine("Hello! Please enter the value");
            double Amount = double.Parse(Console.ReadLine());
            Console.WriteLine(Amount.ToString("C", CultureInfo.CurrentCulture));
        }


    }
}
