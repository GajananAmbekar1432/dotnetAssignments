using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateConsole
{
    public class Brand
    {
        private Guid brandId;
        private string brandName;

        public void setBrandId(Guid brandId)
        {
            this.brandId = brandId;
        }

        public void setBrandName(string brandName)
        {
            this.brandName = brandName;
        }

        public Guid getBrandId()
        {
            return this.brandId;
        }

        public string getBrandName() { 
        
            return this.brandName;
        
        }

    }
}
