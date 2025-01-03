using System.ComponentModel.DataAnnotations;

namespace NimbusPulseAPI.DTOs
{
    public class SecurityCodeChangeDTO
    {
        [Required(ErrorMessage = "Current security code is required")]
        [RegularExpression(@"^\d{4}$", ErrorMessage = "Security code must be exactly 4 digits")]
        public string CurrentSecurityCode { get; set; }

        [Required(ErrorMessage = "New security code is required")]
        [RegularExpression(@"^\d{4}$", ErrorMessage = "Security code must be exactly 4 digits")]
        public string NewSecurityCode { get; set; }

        [Required(ErrorMessage = "Confirm new security code is required")]
        [RegularExpression(@"^\d{4}$", ErrorMessage = "Security code must be exactly 4 digits")]
        [Compare("NewSecurityCode", ErrorMessage = "The new security code and confirmation do not match")]
        public string ConfirmNewSecurityCode { get; set; }
    }
}
