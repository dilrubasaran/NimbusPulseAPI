using AutoMapper;
using Mapster;
using NimbusPulseAPI.DTOs;
using NimbusPulseAPI.Models;
using NimbusPulseAPI.Repository;

namespace NimbusPulseAPI.Services
{

    public interface IDeviceService
    {
        Task<IEnumerable<DeviceDTO>> GetDevicesAsync();
        Task<Device> GetDeviceByIdAsync(int id);
        Task AddDeviceAsync(Device device);
        Task UpdateDeviceAsync(Device device);
        Task DeleteDeviceAsync(Device device);
        Task<IEnumerable<DeviceDTO>> GetDevicesOrderedAsync(string orderBy);
        Task AddDeviceWithApplicationsAsync(Device device);
        Task<DeviceDetailsDTO> GetDeviceDetailsAsync(int id);
    }

    public class DeviceService : IDeviceService
    {
        private readonly IDeviceRepository _deviceRepository;
        

        public DeviceService(IDeviceRepository deviceRepository)
        {
            _deviceRepository = deviceRepository;
          
        }

        public async Task<IEnumerable<DeviceDTO>> GetDevicesAsync()
        {
            var devices = await _deviceRepository.GetAllAsync();
            return devices.Adapt<IEnumerable<DeviceDTO>>();
            
        }

        public async Task<Device> GetDeviceByIdAsync(int id)
        {
            return await _deviceRepository.GetByIdAsync(id);
        }

        public async Task AddDeviceAsync(Device device)
        {
            await _deviceRepository.AddAsync(device);
            
        }

        public async Task UpdateDeviceAsync(Device device)
        {
            await _deviceRepository.UpdateAsync(device); // Add await here
        }


        public async Task DeleteDeviceAsync(Device device)
        {
            await _deviceRepository.DeleteAsync(device);
        }




        //Todo: IQuerable düzeltS
        public async Task<IEnumerable<DeviceDTO>> GetDevicesOrderedAsync(string orderBy)
        {
            Func<IQueryable<Device>, IOrderedQueryable<Device>> orderByExpression = orderBy switch
            {
                "name" => q => q.OrderBy(d => d.Name),
                "status" => q => q.OrderBy(d => d.Status),
                "criticality" => q => q.OrderBy(d => d.HealthStatus == "Critical" ? 1 
                    : d.HealthStatus == "Requires Check" ? 2 
                    : 3),
                _ => q => q.OrderBy(d => d.Name)
            };

            var devices = await _deviceRepository.GetDevicesOrderedAsync(orderByExpression);
            return devices.Adapt<IEnumerable<DeviceDTO>>();
          

        }

        public async Task AddDeviceWithApplicationsAsync(Device device)
        {
            await _deviceRepository.AddDeviceWithApplicationsAsync(device);
        }

        public async Task<DeviceDetailsDTO> GetDeviceDetailsAsync(int id)
        {
            var device = await _deviceRepository.GetDeviceWithApplicationsAsync(id);
            if (device == null)
                return null;

            var deviceDetails = device.Adapt<DeviceDetailsDTO>();


            // Uygulamaları ayır
            deviceDetails.BackgroundApplications = device.Applications
                .Where(a => a.Status != "Active")
                .Select(a => new BackgroundAppDTO
                {
                    Name = a.Name,
                    RunningTime = a.RunningTime,
                    CpuUsage = a.CpuUsage,
                    RamUsage = a.RamUsage
                }).ToList();

            deviceDetails.ActiveApplications = device.Applications
                .Where(a => a.Status == "Active")
                .Select(a => new ActiveAppDTO
                {
                    Name = a.Name,
                    Status = a.Status,
                    RunningTime = a.RunningTime,
                    CpuUsage = a.CpuUsage,
                    RamUsage = a.RamUsage,
                    CpuHistory = Enumerable.Range(0, 20)
                        .Select(i => Math.Min(100, Math.Max(0, a.CpuUsage + Random.Shared.Next(-15, 15))))
                        .ToList(),
                    RamHistory = Enumerable.Range(0, 20)
                        .Select(i => Math.Min(100, Math.Max(0, a.RamUsage + Random.Shared.Next(-10, 10))))
                        .ToList()
                }).ToList();

            return deviceDetails;
        }
    }

}
