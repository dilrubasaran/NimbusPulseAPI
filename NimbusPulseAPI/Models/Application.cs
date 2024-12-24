namespace NimbusPulseAPI.Models
{
    public class Application
    {
        public int Id { get; set; }
        public int DeviceId { get; set; }
        public string Name { get; set; } // Uygulama adı
        public string Status { get; set; } // Örn. "Aktif", "Arka Plan "
        public TimeSpan Duration { get; set; } // Çalışma süresi
        public double CpuUsagePercentage { get; set; }
        public double RamUsagePercentage { get; set; }

        public Device Device { get; set; } // Navigasyon özelliği
    }

}
