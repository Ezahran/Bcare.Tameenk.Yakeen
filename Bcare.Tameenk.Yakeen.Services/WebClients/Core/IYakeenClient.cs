using Bcare.Tameenk.Yakeen.Services.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bcare.Tameenk.Yakeen.Services.WebClients.Core
{
    public interface IYakeenClient
    {      
       
        /// <summary>
        /// data needed in request : (IsCitizen,NIN,DateOfBirth)
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        CustomerNameYakeenInfoDto GetCustomerNameInfo(CustomerYakeenRequestDto request, ServiceRequestLog predefinedLogInfo);

        /// <summary>
        /// data needed in request : (IsCitizen,NIN,DateOfBirth)
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        CustomerIdYakeenInfoDto GetCustomerIdInfo(CustomerYakeenRequestDto request, ServiceRequestLog predefinedLogInfo);

        DriverYakeenInfoDto GetDriverInfo(DriverYakeenRequestDto request, ServiceRequestLog predefinedLogInfo);
    }
}
