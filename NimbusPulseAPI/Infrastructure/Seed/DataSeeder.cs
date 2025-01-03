// using NimbusPulseAPI.Context;
// using NimbusPulseAPI.Models;

// namespace NimbusPulseAPI.Infrastructure.Seed
// {
//     public static class DataSeeder
//     {
//         public static void SeedDatabase(AppDbContext dbContext)
//         {
//             // Kullanıcıları ekle
//             if (!dbContext.Users.Any())
//             {
//                 var users = new List<User>
//             {
//                 new User { Id = 1, Name = "John", SurName = "Doe", Email = "john.doe@example.com", Password = "Pass@123", CompanyName = "TechCorp", PhoneNumber = "+123456789" },
//                 new User { Id = 2, Name = "Jane", SurName = "Smith", Email = "jane.smith@example.com", Password = "Jane@2024", CompanyName = "InnovateLtd", PhoneNumber = "+987654321" },
//                 new User { Id = 3, Name = "Alice", SurName = "Brown", Email = "alice.brown@example.com", Password = "Alice@123", CompanyName = "FutureWorks", PhoneNumber = "+456789123" },
//                 new User { Id = 4, Name = "Bob", SurName = "Johnson", Email = "bob.johnson@example.com", Password = "Bob@Secure", CompanyName = "EnterpriseSolutions", PhoneNumber = "+321654987" },
//                 new User { Id = 5, Name = "Charlie", SurName = "Davis", Email = "charlie.davis@example.com", Password = "Charlie@Secure", CompanyName = "NextGenTech", PhoneNumber = "+789123456" }
//             };
//                 dbContext.Users.AddRange(users);
//             }

//             // Cihazları ekle
//             if (!dbContext.Devices.Any())
//             {
//                 var devices = Enumerable.Range(1, 20).Select(id => new Device
//                 {
//                     Id = id,
//                     Name = $"Device{id:D2}",
//                     Type = id % 2 == 0 ? "Virtual Machine" : "Physical Machine",
//                     OperatingSystem = id % 3 == 0 ? "Linux" : "Windows Server",
//                     IpAddress = $"192.168.{id / 10}.{id}",
//                     Status = id % 5 == 0 ? "Inactive" : "Active",
//                     HealthStatus = id % 4 == 0 ? "Critical" : id % 3 == 0 ? "Requires Check" : "Good",
//                     LastReportDate = DateTime.UtcNow.AddHours(-id),
//                     Uptime = TimeSpan.FromHours(500 + id * 10)
//                 }).ToList();
//                 dbContext.Devices.AddRange(devices);
//             }

//             // Uygulamaları ekle
//             if (!dbContext.Applications.Any())
//             {
//                 var applications = Enumerable.Range(1, 110).Select(id => new Application
//                 {
//                     Id = id,
//                     DeviceId = id % 20 + 1,
//                     Name = id <= 10 ? $"ForegroundApp{id}" : $"BackgroundApp{id - 10}",
//                     Status = id <= 10 ? "Active" : "Inactive",
//                     Duration = TimeSpan.FromHours(id % 24),
//                     CpuUsagePercentage = id <= 10 ? 50 + id : 10 + id % 5,
//                     RamUsagePercentage = id <= 10 ? 60 + id : 20 + id % 10
//                 }).ToList();
//                 dbContext.Applications.AddRange(applications);
//             }

//             // Kaynak kullanımını ekle
//             if (!dbContext.ResourceUsages.Any())
//             {
//                 var resourceUsages = dbContext.Devices.Select(device => new ResourceUsage
//                 {
//                     Id = device.Id,
//                     DeviceId = device.Id,
//                     CpuUsagePercentage = dbContext.Applications.Where(app => app.DeviceId == device.Id).Sum(app => app.CpuUsagePercentage) / dbContext.Applications.Count(app => app.DeviceId == device.Id),
//                     RamUsagePercentage = dbContext.Applications.Where(app => app.DeviceId == device.Id).Sum(app => app.RamUsagePercentage) / dbContext.Applications.Count(app => app.DeviceId == device.Id),
//                     DiskUsagePercentage = new Random().Next(20, 80)
//                 }).ToList();
//                 dbContext.ResourceUsages.AddRange(resourceUsages);
//             }

//             // Logları ekle
//             if (!dbContext.Logs.Any())
//             {
//                 var logs = dbContext.Devices.SelectMany(device => Enumerable.Range(1, 5).Select(logId => new Log
//                 {
//                     Id = logId + device.Id * 10,
//                     DeviceId = device.Id,
//                     Message = device.HealthStatus == "Critical" ? "Device requires urgent attention." : "Device operating normally.",
//                     LogLevel = device.HealthStatus == "Critical" ? "Critical" : "Info",
//                     Timestamp = DateTime.UtcNow.AddMinutes(-logId * device.Id)
//                     //Source = 
//                 })).ToList();
//                 dbContext.Logs.AddRange(logs);
//             }

//             // Bildirimleri ekle
//             if (!dbContext.Notifications.Any())
//             {
//                 var notifications = dbContext.Users.SelectMany(user => Enumerable.Range(1, 3).Select(notificationId => new Notification
//                 {
//                     Id = notificationId + user.Id * 10,
//                     UserId = user.Id,
//                     Title = $"Notification {notificationId}",
//                     Message = $"This is a test notification for {user.Name}.",
//                     IsRead = notificationId % 2 == 0,
//                     SentAt = DateTime.UtcNow.AddMinutes(-notificationId * 5)
//                 })).ToList();
//                 dbContext.Notifications.AddRange(notifications);
//             }

//             //Todo: Alarmları ekle
//             //if (!dbContext.Alerts.Any())
//             //{
//             //    var alerts = dbContext.Devices.SelectMany(device => Enumerable.Range(1, 3).Select(alertId => new Alert
//             //    {
//             //        Id = alertId + device.Id * 10,
//             //        DeviceId = device.Id,
//             //        Type = device.HealthStatus == "Critical" ? "Health" : "CPU",
//             //        Level = device.HealthStatus == "Critical" ? "High" : "Medium",
//             //        Message = $"Alert for device {device.Name}: {device.HealthStatus}.",
//             //        CreatedAt = DateTime.UtcNow.AddMinutes(-alertId * 5)
//             //    })).ToList();
//             //    dbContext.Alerts.AddRange(alerts);
//             //}

//             //dbContext.SaveChanges();
//         }
//     }

// }
