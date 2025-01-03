using Microsoft.EntityFrameworkCore;
using NimbusPulseAPI.Context;
using NimbusPulseAPI.Models;

namespace NimbusPulseAPI.Repository
{

    public interface IDeviceRepository : IRepository<Device>
    {
        Task<IEnumerable<Device>> GetDevicesByStatusAsync(string status);
        Task<IEnumerable<Device>> GetDevicesOrderedAsync(Func<IQueryable<Device>, IOrderedQueryable<Device>> orderBy);
        Task UpdateAsync(Device entity);
        Task AddDeviceWithApplicationsAsync(Device device);
        Task<Device> GetDeviceWithApplicationsAsync(int id);
    }


    public class DeviceRepository : Repository<Device>, IDeviceRepository
    {
        private readonly AppDbContext _context;

        public DeviceRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Device>> GetDevicesByStatusAsync(string status)
        {
            return await _context.Devices.Where(d => d.Status == status).ToListAsync();
        }

        public async Task<IEnumerable<Device>> GetDevicesOrderedAsync(Func<IQueryable<Device>, IOrderedQueryable<Device>> orderBy)
        {
            var query = _context.Devices.AsQueryable();
            return await orderBy(query).ToListAsync();
        }

        public async Task AddDeviceWithApplicationsAsync(Device device)
        {
            await _context.Devices.AddAsync(device);
            await _context.SaveChangesAsync();
        }

        public async Task<Device> GetDeviceWithApplicationsAsync(int id)
        {
            return await _context.Devices
                .Include(d => d.Applications)
                .Include(d => d.ResourceUsage)
                .FirstOrDefaultAsync(d => d.Id == id);
        }
    }

}
