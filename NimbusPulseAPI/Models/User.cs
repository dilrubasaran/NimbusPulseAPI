namespace NimbusPulseAPI.Models
{
    public class User
    {
            public int Id { get; set; }
            public string Name { get; set; } // Kullanıcı adı
            public string SurName { get; set; } // Kullanıcı soyadı
            public string Password { get; set; } // Şifre
            public string Email { get; set; } // E-posta
            public string PhoneNumber { get; set; } // Telefon numarası
            public string CompanyName { get; set; } // Kullanıcı adı
            public string? ProfilePictureUrl { get; set; } // Profil fotoğrafı URL'si
            public DateTime CreatedAt { get; set; } // Hesap oluşturma tarihi

        //Navigasyon özellikleri
            public int? SettingsId { get; set; } // İlişkili ayarlar
            public Settings Settings { get; set; } // Navigasyon özelliği
        

        
    }

}
