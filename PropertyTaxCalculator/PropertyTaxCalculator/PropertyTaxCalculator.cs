using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyTaxCalculator
{
    static class PropertyTaxCalculator
    {
        public static void CalculateTax(ref decimal price, out decimal taxAmount, decimal rate )
        {
            decimal taxRate = rate/100;
            taxAmount = price * taxRate;
            price += taxAmount;
        }
    }
}
