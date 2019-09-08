using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobWebsite.Models.Address
{
    public class Address : Base
    {
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string Town { get; set; }
        public string City { get; set; }
        public string PostCode { get; set; }
        public AddressType AddressType { get; set; }
    }
}
