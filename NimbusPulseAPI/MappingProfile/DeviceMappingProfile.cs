using AutoMapper;
using NimbusPulseAPI.DTOs;
using NimbusPulseAPI.Models;

namespace NimbusPulseAPI.MappingProfile
{
    public class DeviceMappingProfile : Profile
    {
        public DeviceMappingProfile()
        {
            // Device -> DeviceDTO (Temel cihaz bilgileri için)
            CreateMap<Device, DeviceDTO>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.Type))
                .ForMember(dest => dest.OperatingSystem, opt => opt.MapFrom(src => src.OperatingSystem))
                .ForMember(dest => dest.IpAddress, opt => opt.MapFrom(src => src.IpAddress))
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status))
                .ForMember(dest => dest.HealthStatus, opt => opt.MapFrom(src => src.HealthStatus));

            // DeviceDTO -> Device (Yeni cihaz oluşturma için)
            CreateMap<DeviceDTO, Device>()
                .ForMember(dest => dest.Id, opt => opt.Ignore()) // ID otomatik oluşturulacak
                .ForMember(dest => dest.LastReportDate, opt => opt.MapFrom(src => DateTime.UtcNow))
                .ForMember(dest => dest.Uptime, opt => opt.Ignore())
                .ForMember(dest => dest.Applications, opt => opt.Ignore())
                .ForMember(dest => dest.ResourceUsage, opt => opt.Ignore());

            // Device -> DeviceDetailsDTO (Detaylı cihaz bilgileri için)
            CreateMap<Device, DeviceDetailsDTO>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.Type))
                .ForMember(dest => dest.OperatingSystem, opt => opt.MapFrom(src => src.OperatingSystem))
                .ForMember(dest => dest.IpAddress, opt => opt.MapFrom(src => src.IpAddress))
                .ForMember(dest => dest.HealthStatus, opt => opt.MapFrom(src => src.HealthStatus))
                .ForMember(dest => dest.LastReportDate, opt => opt.MapFrom(src => src.LastReportDate))
                .ForMember(dest => dest.ResourceUsage, opt => opt.MapFrom(src => new ResourceUsageDTO
                {
                    CurrentCpuUsage = src.ResourceUsage.CpuUsage,
                    CurrentRamUsage = src.ResourceUsage.RamUsage,
                    CurrentDiskUsage = src.ResourceUsage.DiskUsage,
                    // Geçmiş veriler için örnek - gerçek uygulamada bu veriler veritabanından gelmeli
                    CpuHistory = Enumerable.Range(0, 20).Select(i => 
                        Math.Min(100, Math.Max(0, src.ResourceUsage.CpuUsage + Random.Shared.Next(-20, 20)))).ToList(),
                    RamHistory = Enumerable.Range(0, 20).Select(i => 
                        Math.Min(100, Math.Max(0, src.ResourceUsage.RamUsage + Random.Shared.Next(-10, 10)))).ToList()
                }))
                .ForMember(dest => dest.BackgroundApplications, opt => opt.MapFrom(src => 
                    src.Applications.Where(a => a.Status != "Active").Select(a => new BackgroundAppDTO
                    {
                        Name = a.Name,
                        RunningTime = a.RunningTime,
                        CpuUsage = a.CpuUsage,
                        RamUsage = a.RamUsage
                    })))
                .ForMember(dest => dest.ActiveApplications, opt => opt.MapFrom(src => 
                    src.Applications.Where(a => a.Status == "Active").Select(a => new ActiveAppDTO
                    {
                        Name = a.Name,
                        Status = a.Status,
                        RunningTime = a.RunningTime,
                        CpuUsage = a.CpuUsage,
                        RamUsage = a.RamUsage,
                        // Her uygulama için örnek geçmiş veriler
                        CpuHistory = Enumerable.Range(0, 20).Select(i => 
                            Math.Min(100, Math.Max(0, a.CpuUsage + Random.Shared.Next(-15, 15)))).ToList(),
                        RamHistory = Enumerable.Range(0, 20).Select(i => 
                            Math.Min(100, Math.Max(0, a.RamUsage + Random.Shared.Next(-10, 10)))).ToList()
                    })));

           
            // DeviceDTO -> Device (Uygulama listesi ile birlikte cihaz oluşturma için)
            CreateMap<DeviceDTO, Device>()
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                .ForMember(dest => dest.LastReportDate, opt => opt.MapFrom(src => DateTime.UtcNow))
                .ForMember(dest => dest.Applications, opt => opt.Ignore())
                .ForMember(dest => dest.ResourceUsage, opt => opt.Ignore())
                .ForMember(dest => dest.Uptime, opt => opt.Ignore());
        }
    }
}
