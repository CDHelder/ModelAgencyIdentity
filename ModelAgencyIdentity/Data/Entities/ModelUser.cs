using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModelAgencyIdentity.Data.Entities
{
    public class ModelUser : ApplicationUser
    {
        public string Name { get; set; }
        public string StreetAddress { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public DateTime DOB { get; set; }
    }
}
