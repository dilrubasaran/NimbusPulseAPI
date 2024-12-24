namespace NimbusPulseAPI.Models
{
    public class Settings
    {
        public int Id { get; set; }
        public int UserId { get; set; } // İlişkisel bağlantı
        public string Theme { get; set; } // Tema tipi (Açık, Koyu, Sistem)
        public string Language { get; set; } // Seçilen dil
        public string SecurityCode { get; set; } // Güvenlik kodu 
        public string LanguagePreference { get; set; } // "en", "tr", vb.
        public string NotificationPreference { get; set; } // "Email", "SMS", vb.
        
        public User User { get; set; }
    }

}
