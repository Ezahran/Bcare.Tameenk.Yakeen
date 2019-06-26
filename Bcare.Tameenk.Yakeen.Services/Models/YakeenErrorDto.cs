using Bcare.Tameenk.Yakeen.Services.Models.Enums;

namespace Bcare.Tameenk.Yakeen.Services.Models
{
    public class YakeenErrorDto
    {
        public EErrorType Type { get; set; }

        public string ErrorMessage { get; set; }

        public string ErrorCode { get; set; }

    }
}