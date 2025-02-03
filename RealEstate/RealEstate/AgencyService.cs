using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefractorDelegateExtension
{
    public class AgencyService
    {
        public decimal CalculateCommission(decimal saleAmount, CommissionDelegate commissionDelegate)
        {
            return commissionDelegate(saleAmount);
        }
    }
}
