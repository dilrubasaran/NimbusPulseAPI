namespace NimbusPulseAPI.Models
{
    public class Log
    {
        public int Id { get; set; }
        public string LogLevel { get; set; } // "Info", "Warning", "Error", vb.
        public string Message { get; set; } // Log mesajı
        public DateTime Timestamp { get; set; } // Log zamanı
        public string Source { get; set; } // Kaynak ("Server Monitoring", "Authentication")
    }

}
