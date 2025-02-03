using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateConsole
{
    public class Agency
    {
        private Guid agencyId;
        private string agencyName;
          
        private Guid  brandId;

        public void setAgencyId(Guid agencyId)
        {
            this.agencyId = agencyId;
        }

        public void setAgencyName(string agencyName)
        {
            this.agencyName = agencyName;
        }

        public void setBrandId(Guid brandId)
        {
            this.brandId = brandId;
        }

        public Guid getAgencyId()
        {
            return this.agencyId;
        }

        public string getAgencyName()
        {
            return this.agencyName;
        }

        public Guid getBrandId()
        {
            return this.brandId;

        }


    }
}
