using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bcare.Tameenk.Yakeen.Services.Models
{
    public class CustomerNameYakeenInfoDto
    {
        public CustomerNameYakeenInfoDto()
        {
            Error = new YakeenErrorDto();
        }

        public bool Success { get; set; }
        public YakeenErrorDto Error { get; set; }

        public bool IsCitizen { get; set; }

        public int LogId { get; set; }

        public string EnglishFirstName { get; set; }

        public string EnglishLastName { get; set; }

        public string EnglishSecondName { get; set; }

        public string EnglishThirdName { get; set; }

        public string LastName { get; set; }

        public string SecondName { get; set; }

        public string FirstName { get; set; }

        public string ThirdName { get; set; }

        public string SubtribeName { get; set; }
    }
}