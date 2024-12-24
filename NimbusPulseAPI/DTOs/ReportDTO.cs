namespace NimbusPulseAPI.DTOs
{
    public class ReportDTO
    {   public int Id { get; set; } // Rapor ID'si
        public string DeviceName { get; set; } // Cihaz adı
        public string IpAddress { get; set; } // Cihaz IP adresi
        public string MetricName { get; set; } // İzlenen metrik (ör. CPU Kullanımı)
        public string MetricValue { get; set; } // Metrik değeri
        public DateTime ReportDate { get; set; } // Verinin ulaştığı tarih
    }
}
