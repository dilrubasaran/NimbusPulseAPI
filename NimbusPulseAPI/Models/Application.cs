namespace NimbusPulseAPI.Models
{
    public class Application
    {
        public int Id { get; set; }
        public int DeviceId { get; set; }
        public string Name { get; set; }
        public string Status { get; set; } // Örn. "Aktif", "Pasif"
        public TimeSpan Duration { get; set; }
        public double CpuUsagePercentage { get; set; }
        public double RamUsagePercentage { get; set; }

        public Device Device { get; set; }
    }


}
