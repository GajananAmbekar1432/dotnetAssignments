using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefractorDelegateExtension
{
    public delegate decimal CommissionDelegate(decimal saleAmount);
    public class CommissionCalculator
    {
        public static decimal NormalRate(decimal saleAmount)
        {
            return saleAmount * 0.05m; // 5% commission
        }

        public static decimal PremiumRate(decimal saleAmount)
        {
            return saleAmount * 0.1m; // 10% commission
        }
    }
}
