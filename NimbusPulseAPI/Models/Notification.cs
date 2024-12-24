namespace NimbusPulseAPI.Models
{
    public class Notification
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public string Title { get; set; } // Bildirim başlığı
        public string Message { get; set; } // Bildirim mesajı
        public DateTime SentAt { get; set; } // Gönderim tarihi

        //:TODO: Okundu bilgisini sonradan çok sonradan ekleyeceksin 
        public bool IsRead { get; set; } // Okundu bilgisi


    }

}
