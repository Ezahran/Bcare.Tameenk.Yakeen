using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Bcare.Tameenk.Yakeen.Services.Models.Enums;

namespace Bcare.Tameenk.Yakeen.Services.Models
{
    public class DriverYakeenInfoDto
    {
        public DriverYakeenInfoDto()
        {
            Error = new YakeenErrorDto();
            Licenses = new List<DriverLicenseYakeenInfoDto>();
        }

        public bool Success { get; set; }
        public YakeenErrorDto Error { get; set; }

        public bool IsCitizen { get; set; }

        public string EnglishFirstName { get; set; }

        public string EnglishLastName { get; set; }

        public string EnglishSecondName { get; set; }

        public string EnglishThirdName { get; set; }

        public string LastName { get; set; }

        public string SecondName { get; set; }

        public string FirstName { get; set; }

        public string ThirdName { get; set; }

        public string SubtribeName { get; set; }

        public IList<DriverLicenseYakeenInfoDto> Licenses { get; set; }

        public EGender Gender { get; set; }

        public short NationalityCode { get; set; }

        /// <summary>
        /// format : (dd-MM-yyyy)
        /// </summary>
        /// 
        public DateTime DateOfBirthG { get; set; }
        /// <summary>
        /// format : (dd-MM-yyyy)
        /// </summary>
        /// 
        public string DateOfBirthH { get; set; }
    }
}