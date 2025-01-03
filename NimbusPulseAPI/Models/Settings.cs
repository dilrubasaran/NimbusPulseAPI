namespace NimbusPulseAPI.Models
{
    public class Settings
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Theme { get; set; } = "Light";
        public string Language { get; set; } = "en";
        public string SecurityCode { get; set; } = "0000";
        public string LanguagePreference { get; set; } = "en";
        public string NotificationPreference { get; set; } = "Email";
        
        public User User { get; set; }
    }

}
