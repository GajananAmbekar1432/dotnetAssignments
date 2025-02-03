using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyTaxCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ResidentialProperty residential = new ResidentialProperty(Guid.NewGuid(), " Vajirabad Nanded Maharashtra", 700000m);
            Console.WriteLine("Residential Property Details\n \nPrice before tax...");

            Console.WriteLine(residential.GetDetails());
            Console.WriteLine("\nPrice after tax...");

            decimal taxRate = 5.5m;
            decimal residentialTax;
            PropertyTaxCalculator.CalculateTax(ref residential.Price, out residentialTax, taxRate);
            Console.WriteLine($"Price: INR {residential.Price}\nTax: INR {residentialTax}\ntaxRate: {taxRate} %");

            CommercialProperty commercial = new CommercialProperty(Guid.NewGuid(), "Anand Nagar Nanded Maharashtra", 15000000m);
            Console.WriteLine("\nCommercial Property Details\n \nPrice before tax");
            Console.WriteLine(commercial.GetDetails());

            Console.WriteLine("\nPrice after tax...");
            decimal commercialTax;
            PropertyTaxCalculator.CalculateTax(ref commercial.Price, out commercialTax, taxRate);
            Console.WriteLine($"Price: INR {commercial.Price}\nTax: INR {commercialTax}\ntaxRate: {taxRate} %");




        }
     
    }
}
