using System.ComponentModel.DataAnnotations;

namespace NimbusPulseAPI.DTOs
{
    public class CreateDeviceWithAppsDTO
    {
        // Device bilgileri
        [Required(ErrorMessage = "Name is required")]
        public required string Name { get; set; }

        [Required(ErrorMessage = "Type is required")]
        public required string Type { get; set; }

        [Required(ErrorMessage = "Operating System is required")]
        public required string OperatingSystem { get; set; }

        [Required(ErrorMessage = "IP Address is required")]
        public required string IpAddress { get; set; }

        [Required(ErrorMessage = "Status is required")]
        public required string Status { get; set; }

        [Required(ErrorMessage = "Health Status is required")]
        public required string HealthStatus { get; set; }

        // Application listesi
        public List<ApplicationDTO> Applications { get; set; }
    }

    public class ApplicationDTO
    {
        [Required]
        public string Name { get; set; }
        public  string Status { get; set; }
        public double CpuUsage { get; set; }
        public double MemoryUsage { get; set; }
        public double RamUsage { get; set; }
        public TimeSpan RunningTime { get; set; }
    }
} 