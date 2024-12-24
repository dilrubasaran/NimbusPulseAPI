namespace NimbusPulseAPI.Models
{
    public class ResourceUsage
    {
        public int Id { get; set; }
        public int DeviceId { get; set; } // İlişkili sunucu
        public double CpuUsagePercentage { get; set; } // CPU kullanım yüzdesi
        public double RamUsagePercentage { get; set; } // RAM kullanım yüzdesi
        public double DiskUsagePercentage { get; set; } // Disk kullanım yüzdesi

        // Hard disk detayları
        public double SystemFilesUsage { get; set; }
        public double UserFilesUsage { get; set; }
        public double TemporaryFilesUsage { get; set; }
        public double ApplicationsUsage { get; set; }
        public double BackupsUsage { get; set; }

        public Device Device  { get; set; } // Navigasyon özelliği
    }


}
