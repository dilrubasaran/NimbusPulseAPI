using static System.Net.Mime.MediaTypeNames;

namespace NimbusPulseAPI.Models
{
    public class Device
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; } // Örn. "Virtual Machine" , "Physical Machine" 
        public string OperatingSystem { get; set; }
        public string IpAddress { get; set; }
        public string Status { get; set; } // Örn: "Active", "Inactive"
        public string HealthStatus { get; set; } // Örn: "Good", "Critical", "Requires Check"
        public DateTime LastReportDate { get; set; } // En son rapor tarihi
        
        // Uygulama Kullanımı
        public ICollection<Application> ActiveApplications { get; set; } // Aktif kullanılan uygulamalar
        public ICollection<Application> InactiveApplications { get; set; } // Pasif kullanılan uygulamalar

        // Çalışma Süresi
        public TimeSpan Uptime { get; set; } // Cihazın ne kadar süredir çalıştığı

        // Navigasyon özellikleri
        public ResourceUsage ResourceUsage { get; set; } // Kaynak kullanımı
       
    }


}
