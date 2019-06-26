using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bcare.Tameenk.Yakeen.Services.Models
{
    public class DriverYakeenRequestDto
    {
        public readonly string ReferenceNumber;
        public bool IsCitizen { get; set; }
        public long Nin { get; set; }
        public string LicenseExpiryDate { get; set; }

        public DriverYakeenRequestDto()
        {
            ReferenceNumber = Guid.NewGuid().ToString().Replace("-", string.Empty).Substring(0, 15);
        }
    }
}