using static System.Net.Mime.MediaTypeNames;

namespace NimbusPulseAPI.Models
{
    public class Device
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string OperatingSystem { get; set; }
        public string IpAddress { get; set; }
        public string Status { get; set; } // Örn: "Active", "Inactive"
        public string HealthStatus { get; set; } // Örn: "Good", "Critical", "Requires Check"
        public DateTime LastReportDate { get; set; }
        public TimeSpan Uptime { get; set; }

        // Uygulama Kullanımı
        public ICollection<Application> Applications { get; set; } // Tüm uygulamalar (aktif/pasif bilgisi Application.Status'ta)

        // Navigasyon özellikleri
        public ResourceUsage ResourceUsage { get; set; }
    }


}
