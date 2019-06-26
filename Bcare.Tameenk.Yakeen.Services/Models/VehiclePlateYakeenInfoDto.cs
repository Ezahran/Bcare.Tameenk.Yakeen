using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bcare.Tameenk.Yakeen.Services.Models
{
    public class VehiclePlateYakeenInfoDto
    {
        public VehiclePlateYakeenInfoDto()
        {
            Error = new YakeenErrorDto();
        }

        public bool Success { get; set; }
        public YakeenErrorDto Error { get; set; }

        public string ChassisNumber { get; set; }

        public int LogId { get; set; }

        public string OwnerName { get; set; }

        public short PlateNumber { get; set; }

        public string PlateText1 { get; set; }

        public string PlateText2 { get; set; }

        public string PlateText3 { get; set; }
    }
}