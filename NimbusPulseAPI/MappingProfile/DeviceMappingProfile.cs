using AutoMapper;
using NimbusPulseAPI.DTOs;
using NimbusPulseAPI.Models;

namespace NimbusPulseAPI.MappingProfile
{
    public class DeviceMappingProfile : Profile
    {
        public DeviceMappingProfile()
        {
            // Model -> DTO
            CreateMap<Device, DeviceDTO>()
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status)) // Durum bilgisi doğrudan eşlenir.
                .ForMember(dest => dest.HealthStatus, opt => opt.MapFrom(src => src.HealthStatus)) // Sağlık durumu eşlenir.
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name)) // İsim eşlenir.
                .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.Type)) // Cihaz türü eşlenir.
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id)) // ID eşlenir.
                .ReverseMap(); // DTO -> Model dönüşümü otomatik yapılır.

            // Eğer DTO'da olmayan bir özellik varsa, onu yok sayabiliriz.
            CreateMap<DeviceDTO, Device>()
                .ForMember(dest => dest.LastReportDate, opt => opt.Ignore()) // DTO'da olmayan alanı yok sayıyoruz.
                .ForMember(dest => dest.OperatingSystem, opt => opt.Ignore()) // DTO'da olmayan alan
                .ForMember(dest => dest.IpAddress, opt => opt.Ignore()) // DTO'da olmayan alan
                .ForMember(dest => dest.Uptime, opt => opt.Ignore()) // DTO'da olmayan alan
                .ForMember(dest => dest.Applications, opt => opt.Ignore()) // Navigasyon özelliği
                .ForMember(dest => dest.ResourceUsage, opt => opt.Ignore()); // Navigasyon özelliği
        }
    }
}
