using NimbusPulseAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using NimbusPulseAPI.DTOs;



namespace NimbusPulseAPI.Context
{ 
    public class AppDbContext : DbContext
        {
            // DbSet tanımlamaları
            public DbSet<Application> Applications { get; set; }
            public DbSet<Device> Devices { get; set; }
            public DbSet<Log> Logs { get; set; }
            public DbSet<Notification> Notifications { get; set; }
            public DbSet<ResourceUsage> ResourceUsages { get; set; }
            public DbSet<Settings> Settings { get; set; }
            public DbSet<User> Users { get; set; }

            // Constructor
            public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.ConfigureWarnings(warnings => warnings.Ignore(RelationalEventId.PendingModelChangesWarning));
                base.OnConfiguring(optionsBuilder);
            }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                // İlişkileri tanımlama
                modelBuilder.Entity<Notification>()
                    .HasOne(n => n.User)
                    .WithMany()
                    .HasForeignKey(n => n.UserId)
                    .OnDelete(DeleteBehavior.Cascade);

                modelBuilder.Entity<Settings>()
                    .HasOne(s => s.User)
                    .WithOne(u => u.Settings)
                    .HasForeignKey<User>(u => u.SettingsId)
                    .OnDelete(DeleteBehavior.Cascade);

                modelBuilder.Entity<ResourceUsage>()
                    .HasOne(r => r.Device)
                    .WithOne(d => d.ResourceUsage)
                    .HasForeignKey<ResourceUsage>(r => r.DeviceId)
                    .OnDelete(DeleteBehavior.Cascade);

                modelBuilder.Entity<Application>()
                    .HasOne(a => a.Device)
                    .WithMany(d => d.Applications)
                    .HasForeignKey(a => a.DeviceId)
                    .OnDelete(DeleteBehavior.Cascade);

                // DTO'ları ignore et
                modelBuilder.Ignore<DeviceDTO>();
                modelBuilder.Ignore<CreateDeviceWithAppsDTO>();
                modelBuilder.Ignore<DeviceDetailsDTO>();
                modelBuilder.Ignore<ResourceUsageDTO>();
                modelBuilder.Ignore<BackgroundAppDTO>();
                modelBuilder.Ignore<ActiveAppDTO>();
                modelBuilder.Ignore<ApplicationDTO>();

                // Seed data
                new DbInitializer(modelBuilder).Seed();
            }
            
        }
    

}
