namespace NimbusPulseAPI.Models
{
    public class Application
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public double CpuUsage { get; set; }
        public double RamUsage { get; set; }
        public TimeSpan RunningTime { get; set; }
        public int DeviceId { get; set; }
        public Device Device { get; set; }
    }
}
