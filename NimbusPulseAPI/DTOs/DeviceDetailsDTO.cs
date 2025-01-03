namespace NimbusPulseAPI.DTOs
{
    public class DeviceDetailsDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string OperatingSystem { get; set; }
        public string IpAddress { get; set; }
        public string Status { get; set; }
        public string HealthStatus { get; set; }
        public DateTime LastReportDate { get; set; }

        // Genel Kaynak Kullanımı
        public ResourceUsageDTO ResourceUsage { get; set; }

        // Arka Planda Çalışan Uygulamalar
        public List<BackgroundAppDTO> BackgroundApplications { get; set; }

        // Aktif Çalışan Uygulamalar
        public List<ActiveAppDTO> ActiveApplications { get; set; }
    }

    public class ResourceUsageDTO
    {
        public List<double> CpuHistory { get; set; } // CPU kullanım geçmişi grafiği için
        public List<double> RamHistory { get; set; } // RAM kullanım geçmişi grafiği için
        public double CurrentCpuUsage { get; set; }
        public double CurrentRamUsage { get; set; }
        public double CurrentDiskUsage { get; set; }
    }

    public class BackgroundAppDTO
    {
        public string Name { get; set; }
        public TimeSpan RunningTime { get; set; }
        public double CpuUsage { get; set; }
        public double RamUsage { get; set; }
    }

    public class ActiveAppDTO
    {
        public string Name { get; set; }
        public string Status { get; set; }
        public TimeSpan RunningTime { get; set; }
        public double CpuUsage { get; set; }
        public double RamUsage { get; set; }
        // Küçük grafik için geçmiş veriler
        public List<double> CpuHistory { get; set; }
        public List<double> RamHistory { get; set; }
    }
}
