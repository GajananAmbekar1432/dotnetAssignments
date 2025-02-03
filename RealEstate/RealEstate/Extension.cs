using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefractorDelegateExtension
{
 public static class Extension
    {
        public static bool IsValidAgencyName(this string agencyName)
        {
            return !string.IsNullOrEmpty(agencyName) && agencyName.Contains("Realty");
        }
    }
}
