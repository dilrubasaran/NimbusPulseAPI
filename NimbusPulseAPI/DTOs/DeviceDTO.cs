namespace NimbusPulseAPI.DTOs
{
    public class DeviceDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } // Cihaz ismi
        public string Type { get; set; } // Cihaz türü (Laptop, VM vs.)
        public string Status { get; set; } // Cihaz durumu (Çalışıyor, Kapalı)
        public string HealthStatus { get; set; } // Sunucu durumu (İyi, Kritik, Kontrol Gerektiriyor)
    }
}
