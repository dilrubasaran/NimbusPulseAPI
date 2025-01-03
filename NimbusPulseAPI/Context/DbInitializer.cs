using NimbusPulseAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace NimbusPulseAPI.Context
{
    public class DbInitializer(ModelBuilder modelBuilder)
    {
        public void Seed()
        {
            // Seed Data - User
            var users = new User[]
            {
                new User { Id = 1, Name = "John", SurName = "Doe", Email = "john.doe@example.com", Password = "Pass@123", CompanyName = "TechCorp", PhoneNumber = "+123456789" },
                new User { Id = 2, Name = "Jane", SurName = "Smith", Email = "jane.smith@example.com", Password = "Jane@2024", CompanyName = "InnovateLtd", PhoneNumber = "+987654321" },
                new User { Id = 3, Name = "Alice", SurName = "Brown", Email = "alice.brown@example.com", Password = "Alice@123", CompanyName = "FutureWorks", PhoneNumber = "+456789123" },
                new User { Id = 4, Name = "Bob", SurName = "Johnson", Email = "bob.johnson@example.com", Password = "Bob@Secure", CompanyName = "EnterpriseSolutions", PhoneNumber = "+321654987" },
                new User { Id = 5, Name = "Charlie", SurName = "Davis", Email = "charlie.davis@example.com", Password = "Charlie@Secure", CompanyName = "NextGenTech", PhoneNumber = "+789123456" }
            };
            modelBuilder.Entity<User>().HasData(users);

            // Seed Data - Device
            var devices = Enumerable.Range(1, 20).Select(id => new Device
            {
                Id = id,
                Name = $"Device{id:D2}",
                Type = id % 2 == 0 ? "Virtual Machine" : "Physical Machine",
                OperatingSystem = id % 3 == 0 ? "Linux" : "Windows Server",
                IpAddress = $"192.168.{id / 10}.{id}",
                Status = id % 5 == 0 ? "Inactive" : "Active",
                HealthStatus = id % 4 == 0 ? "Critical" : id % 3 == 0 ? "Requires Check" : "Good",
                LastReportDate = DateTime.UtcNow.AddHours(-id)
            }).ToArray();
            modelBuilder.Entity<Device>().HasData(devices);

            // Seed Data - Application (Background Apps)
            var backgroundApps = Enumerable.Range(1, 100).Select(id => new Application
            {
                Id = id,
                DeviceId = 1, // Hepsi Device 1'e bağlı
                Name = $"BackgroundApp{id}",
                Status = "Inactive",
                RunningTime = TimeSpan.FromHours(id % 24),
                CpuUsage = 5 + (id % 10), // 5-15 arası CPU kullanımı
                RamUsage = 10 + (id % 15) // 10-25 arası RAM kullanımı
            }).ToArray();

            // Seed Data - Application (Active Apps)
            var activeApps = Enumerable.Range(101, 8).Select(id => new Application
            {
                Id = id,
                DeviceId = 1, // Hepsi Device 1'e bağlı
                Name = $"ActiveApp{id-100}", // 1'den 8'e kadar
                Status = "Active",
                RunningTime = TimeSpan.FromHours(id % 24),
                CpuUsage = 30 + (id % 20), // 30-50 arası CPU kullanımı
                RamUsage = 40 + (id % 30) // 40-70 arası RAM kullanımı
            }).ToArray();

            var allApps = backgroundApps.Concat(activeApps).ToArray();
            modelBuilder.Entity<Application>().HasData(allApps);

            // Seed Data - ResourceUsage
            var resourceUsage = new ResourceUsage
            {
                Id = 1,
                DeviceId = 1,
                CpuUsage = 45.5,
                RamUsage = 62.3,
                DiskUsage = 78.1
            };
            modelBuilder.Entity<ResourceUsage>().HasData(resourceUsage);

            // Seed Data - Log
            var logs = Enumerable.Range(1, 100).Select(id => new Log
            {
                Id = id,
                DeviceId = (id - 1) / 5 + 1,
                Message = id % 4 == 0 ? "Device requires urgent attention." : "Device operating normally.",
                LogLevel = id % 4 == 0 ? "Critical" : "Info",
                Timestamp = DateTime.UtcNow.AddMinutes(-id * 5),
                Source = id % 2 == 0 ? "Server Monitoring" : "Authentication"
            }).ToArray();
            modelBuilder.Entity<Log>().HasData(logs);

            // Seed Data - Notification
            var notifications = Enumerable.Range(1, 15).Select(id => new Notification
            {
                Id = id,
                UserId = (id - 1) / 3 + 1,
                Title = $"Notification {id}",
                Message = $"This is a test notification for user {(id - 1) / 3 + 1}.",
                IsRead = id % 2 == 0,
                SentAt = DateTime.UtcNow.AddMinutes(-id * 5)
            }).ToArray();
            modelBuilder.Entity<Notification>().HasData(notifications);
        }
    }
}