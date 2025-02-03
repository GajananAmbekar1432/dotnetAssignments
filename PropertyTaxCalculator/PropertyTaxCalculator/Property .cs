using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyTaxCalculator
{
    abstract class Property
    {
        public Guid propertyId {  get; set; }
        public string Address {  get; set; }

        public decimal Price;


        public Property()
        {  }

        public Property(Guid propertyId, string address, decimal price)
        {
            this.propertyId = propertyId;
            Address = address;
            Price = price;
        }

        public abstract string GetDetails();


    }
}
