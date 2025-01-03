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
            var devices = new List<Device>();
            int deviceId = 1;

            // 13 Active-Good Device
            for (int i = 0; i < 13; i++)
            {
                devices.Add(new Device
                {
                    Id = deviceId++,
                    Name = $"Server{i + 1:D2}",
                    Type = i % 2 == 0 ? "Virtual Machine" : "Physical Server",
                    OperatingSystem = i % 3 == 0 ? "Linux" : "Windows Server",
                    IpAddress = $"192.168.{i / 10}.{i % 10}",
                    Status = "Active",
                    HealthStatus = "Good",
                    LastReportDate = DateTime.UtcNow.AddMinutes(-i * 30)
                });
            }

            // 3 Active-Requires Check Device
            for (int i = 0; i < 3; i++)
            {
                devices.Add(new Device
                {
                    Id = deviceId++,
                    Name = $"Database{i + 1:D2}",
                    Type = "Database Server",
                    OperatingSystem = i % 2 == 0 ? "Linux" : "Windows Server",
                    IpAddress = $"192.168.1.{100 + i}",
                    Status = "Active",
                    HealthStatus = "Requires Check",
                    LastReportDate = DateTime.UtcNow.AddHours(-i)
                });
            }

            // 2 Active-Critical Device
            for (int i = 0; i < 2; i++)
            {
                devices.Add(new Device
                {
                    Id = deviceId++,
                    Name = $"Gateway{i + 1:D2}",
                    Type = "Network Device",
                    OperatingSystem = "Linux",
                    IpAddress = $"192.168.2.{i + 1}",
                    Status = "Active",
                    HealthStatus = "Critical",
                    LastReportDate = DateTime.UtcNow.AddMinutes(-15)
                });
            }

            // 2 Inactive Device
            for (int i = 0; i < 2; i++)
            {
                devices.Add(new Device
                {
                    Id = deviceId++,
                    Name = $"Backup{i + 1:D2}",
                    Type = "Storage Server",
                    OperatingSystem = "Windows Server",
                    IpAddress = $"192.168.3.{i + 1}",
                    Status = "Inactive",
                    HealthStatus = "Unknown",
                    LastReportDate = DateTime.UtcNow.AddDays(-1)
                });
            }

            modelBuilder.Entity<Device>().HasData(devices);

            // Her cihaz için uygulamalar oluştur
            var applications = new List<Application>();
            int appId = 1;

            foreach (var device in devices)
            {
                // Aktif cihazlar için daha fazla uygulama
                if (device.Status == "Active")
                {
                    // 4-8 arası aktif uygulama
                    int activeAppCount = new Random().Next(4, 9);
                    for (int i = 0; i < activeAppCount; i++)
                    {
                        applications.Add(new Application
                        {
                            Id = appId++,
                            DeviceId = device.Id,
                            Name = $"ActiveApp_{device.Id}_{i + 1}",
                            Status = "Active",
                            RunningTime = TimeSpan.FromHours(new Random().Next(1, 72)),
                            CpuUsage = 30 + new Random().Next(0, 40),
                            RamUsage = 40 + new Random().Next(0, 35)
                        });
                    }

                    // 20-30 arası background uygulama
                    int bgAppCount = new Random().Next(20, 31);
                    for (int i = 0; i < bgAppCount; i++)
                    {
                        applications.Add(new Application
                        {
                            Id = appId++,
                            DeviceId = device.Id,
                            Name = $"BgApp_{device.Id}_{i + 1}",
                            Status = "Inactive",
                            RunningTime = TimeSpan.FromHours(new Random().Next(1, 48)),
                            CpuUsage = new Random().Next(5, 15),
                            RamUsage = new Random().Next(10, 25)
                        });
                    }
                }
            }

            modelBuilder.Entity<Application>().HasData(applications);

            // Her aktif cihaz için kaynak kullanımı
            var resourceUsages = devices.Where(d => d.Status == "Active").Select(device => new ResourceUsage
            {
                Id = device.Id,
                DeviceId = device.Id,
                CpuUsage = device.HealthStatus == "Critical" ? 85 + new Random().Next(0, 15) :
                           device.HealthStatus == "Requires Check" ? 70 + new Random().Next(0, 15) :
                           40 + new Random().Next(0, 30),
                RamUsage = device.HealthStatus == "Critical" ? 90 + new Random().Next(0, 10) :
                           device.HealthStatus == "Requires Check" ? 75 + new Random().Next(0, 15) :
                           50 + new Random().Next(0, 30),
                DiskUsage = device.HealthStatus == "Critical" ? 95 + new Random().Next(0, 5) :
                            device.HealthStatus == "Requires Check" ? 80 + new Random().Next(0, 10) :
                            60 + new Random().Next(0, 20)
            }).ToList();

            modelBuilder.Entity<ResourceUsage>().HasData(resourceUsages);

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