namespace NimbusPulseAPI.Models
{
    public class ResourceUsage
    {
        public int Id { get; set; }
        public int DeviceId { get; set; }
        public double CpuUsage { get; set; }
        public double RamUsage { get; set; }
        public double DiskUsage { get; set; }
        public Device Device { get; set; }
    }
}
