using System;
using System.Collections.Generic;
using System.Text;

namespace Bcare.Tameenk.Yakeen.Services.WebClients.Implementation
{
    public class YakeenOutput
    {
        public enum ErrorCodes
        {
            Success = 1,
            NullResponse,
            UnspecifiedError,
            ServiceError,
            NullRequest,
            ServiceException
        }
        public ErrorCodes ErrorCode
        {
            get;
            set;
        }
        public string ErrorDescription
        {
            get;
            set;
        }
        
        public CustomerNameYakeenInfoDto CustomerYakeenInfo
        {
            get;
            set;
        }
        public CustomerIdYakeenInfoDto CustomerIdYakeenInfoDto
        {
            get;
            set;
        }
        public DriverYakeenInfoDto DriverYakeenInfoDto
        {
            get;
            set;
        }
     

    }
}
