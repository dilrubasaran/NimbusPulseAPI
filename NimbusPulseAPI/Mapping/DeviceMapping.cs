using Mapster;
using NimbusPulseAPI.DTOs;
using NimbusPulseAPI.Models;

namespace NimbusPulseAPI.Mapping
{
    public class DeviceMapping :IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            
            // Device -> DeviceDTO (Temel cihaz bilgileri için)
            config.NewConfig<Device, DeviceDTO>();

            //butün propertyler aynı olduğu için vermedim

            // DeviceDTO -> Device (Yeni cihaz oluşturma için)
            config.NewConfig<DeviceDTO, Device>()
                .Ignore(dest => dest.Id)
                .Map(dest => dest.LastReportDate, src => DateTime.UtcNow)
                .Ignore(dest => dest.Uptime)
                .Ignore(dest => dest.Applications)
                .Ignore(dest => dest.ResourceUsage);

            // Device -> DeviceDetailsDTO (Detaylı cihaz bilgileri için)
            config.NewConfig<Device, DeviceDetailsDTO>()

                .Map(dest => dest.ResourceUsage, src => new ResourceUsageDTO
                {
                    CurrentCpuUsage = src.ResourceUsage.CpuUsage,
                    CurrentRamUsage = src.ResourceUsage.RamUsage,
                    CurrentDiskUsage = src.ResourceUsage.DiskUsage,
                    // Geçmiş veriler için örnek - gerçek uygulamada bu veriler veritabanından gelmeli
                    CpuHistory = Enumerable.Range(0, 20).Select(i =>
                        Math.Min(100, Math.Max(0, src.ResourceUsage.CpuUsage + Random.Shared.Next(-20, 20)))).ToList(),
                    RamHistory = Enumerable.Range(0, 20).Select(i =>
                        Math.Min(100, Math.Max(0, src.ResourceUsage.RamUsage + Random.Shared.Next(-10, 10)))).ToList()
                })
                .Map(dest => dest.BackgroundApplications, src =>
                    src.Applications.Where(a => a.Status != "Active").Select(a => new BackgroundAppDTO
                    {
                        Name = a.Name,
                        RunningTime = a.RunningTime,
                        CpuUsage = a.CpuUsage,
                        RamUsage = a.RamUsage
                    }).ToList()
                )
                .Map(dest => dest.ActiveApplications, src =>
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
                    }).ToList()
                );


            // DeviceDTO -> Device (Uygulama listesi ile birlikte cihaz oluşturma için)
            config.NewConfig<DeviceDTO, Device>()
                .Ignore(dest => dest.Id)
                .Map(dest => dest.LastReportDate, (src => DateTime.UtcNow))
                .Ignore(dest => dest.Applications)
                .Ignore(dest => dest.ResourceUsage)
                .Ignore(dest => dest.Uptime);
        }
    }
}
