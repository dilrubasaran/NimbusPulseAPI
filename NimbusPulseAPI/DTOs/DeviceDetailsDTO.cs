namespace NimbusPulseAPI.DTOs
{
    public class DeviceDetailsDTO
    {
            public int Id { get; set; }
            public string Name { get; set; } // Cihaz ismi
            public string Type { get; set; } // Cihaz türü (Laptop, VM vs.)
            public string HealthStatus { get; set; } // Sunucu durumu
            public string OperatingSystem { get; set; } // İşletim sistemi
            public string IpAddress { get; set; } // Cihaz IP adresi
            public DateTime LastReportDate { get; set; } // Verinin gönderildiği tarih

            // Kaynak Kullanımı
            public double CpuUsagePercentage { get; set; }
            public double RamUsagePercentage { get; set; }
            public double DiskUsagePercentage { get; set; }

            // Uygulamalar
            public List<ApplicationUsageDTO> ActiveApplications { get; set; }
            public List<ApplicationUsageDTO> InactiveApplications { get; set; }
        }

        public class ApplicationUsageDTO
        {
            public string Name { get; set; } // Uygulama adı
            public TimeSpan Duration { get; set; } // Çalışma süresi
            public double CpuUsagePercentage { get; set; } // CPU kullanımı
            public double RamUsagePercentage { get; set; } // RAM kullanımı
        }
    
}
