using System.ComponentModel.DataAnnotations;

namespace NimbusPulseAPI.DTOs
{
    public class CreateDeviceDTO
    {
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Type is required")]
        public string Type { get; set; }

        [Required(ErrorMessage = "Operating System is required")]
        public string OperatingSystem { get; set; }

        [Required(ErrorMessage = "IP Address is required")]
        public string IpAddress { get; set; }

        [Required(ErrorMessage = "Status is required")]
        public string Status { get; set; }

        [Required(ErrorMessage = "Health Status is required")]
        public string HealthStatus { get; set; }
    }
} 