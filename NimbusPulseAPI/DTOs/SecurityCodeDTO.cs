namespace NimbusPulseAPI.DTOs
{
    public class SecurityCodeChangeDTO
    {
        public string CurrentSecurityCode { get; set; }
        public string NewSecurityCode { get; set; }
        public string ConfirmNewSecurityCode { get; set; }
    }
}
