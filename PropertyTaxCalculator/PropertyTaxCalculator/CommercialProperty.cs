using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyTaxCalculator
{
    internal class CommercialProperty : Property
    {
        public CommercialProperty(Guid propertyId, string Address, decimal price):base(propertyId, Address, price) { }
       
        public override string GetDetails()
        {
            return $"propertyId: {propertyId}\nAddress: {Address}\nPrice:INR {Price}";
        }
    }
}
