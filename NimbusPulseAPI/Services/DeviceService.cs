
using AutoMapper;
using NimbusPulseAPI.DTOs;
using NimbusPulseAPI.Models;
using NimbusPulseAPI.Repository;

namespace NimbusPulseAPI.Services
{

    public interface IDeviceService
    {
        Task<IEnumerable<DeviceDTO>> GetDevicesAsync();
        Task<DeviceDetailsDTO> GetDeviceByIdAsync(int id);
        Task AddDeviceAsync(Device device);
        Task UpdateDeviceAsync(Device device);
        Task DeleteDeviceAsync(Device id);
        Task<IEnumerable<DeviceDTO>> GetDevicesOrderedAsync(string orderBy);
    }

    public class DeviceService : IDeviceService
    {
        private readonly IDeviceRepository _deviceRepository;
        private readonly IMapper _mapper;

        public DeviceService(IDeviceRepository deviceRepository, IMapper mapper)
        {
            _deviceRepository = deviceRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<DeviceDTO>> GetDevicesAsync()
        {
            var devices = await _deviceRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<DeviceDTO>>(devices);
        }

        public async Task<DeviceDetailsDTO> GetDeviceByIdAsync(int id)
        {
            var device = await _deviceRepository.GetByIdAsync(id);
            return _mapper.Map<DeviceDetailsDTO>(device);
        }

        public async Task AddDeviceAsync(Device device)
        {
            await _deviceRepository.AddAsync(device);
        }

        public async Task UpdateDeviceAsync(Device device)
        {
            await _deviceRepository.UpdateAsync(device); // Add await here
        }


        public async Task DeleteDeviceAsync(Device id)
        {
            await _deviceRepository.DeleteAsync(id);
        }
        //Todo: IQuerable düzeltS
        public async Task<IEnumerable<DeviceDTO>> GetDevicesOrderedAsync(string orderBy)
        {
            Func<IQueryable<Device>, IOrderedQueryable<Device>> orderByExpression = orderBy switch
            {
                "name" => q => q.OrderBy(d => d.Name),
                "status" => q => q.OrderBy(d => d.Status),
                "criticality" => q => q.OrderBy(d => d.HealthStatus == "Kritik" ? 1
                    : d.HealthStatus == "Kontrol Gerektiriyor" ? 2
                    : 3), // Öncelik sırasına göre sıralama
                _ => q => q.OrderBy(d => d.Name)
            };

            var devices = await _deviceRepository.GetDevicesOrderedAsync(orderByExpression);
            return _mapper.Map<IQueryable<DeviceDTO>>(devices);
        }

    }

}
