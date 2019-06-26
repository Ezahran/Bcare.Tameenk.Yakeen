using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bcare.Tameenk.Yakeen.Services.Models
{
    public class VehicleYakeenRequestDto
    {
        public readonly string ReferenceNumber;
        public long VehicleId { get; set; }
        public int VehicleIdTypeId{ get; set; }
        public long OwnerNin { get; set; }
        public short? ModelYear { get; set; }

        public VehicleYakeenRequestDto()
        {
            ReferenceNumber = Guid.NewGuid().ToString().Replace("-", string.Empty).Substring(0, 15);
        }
    }
}