using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyTaxCalculator
{
    internal class ResidentialProperty : Property
    {
        public ResidentialProperty(Guid propertyId, string Address, decimal price)
        {
            base.propertyId=propertyId;
            base.Address=Address;
            base.Price=price;
        }
       
        public override string GetDetails()
        {
            return $"PropertyID: {propertyId}\nAddress: {Address}\nPrice:INR {Price}";
        }
    }
}
