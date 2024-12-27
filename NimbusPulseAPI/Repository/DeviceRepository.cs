using Microsoft.EntityFrameworkCore;
using NimbusPulseAPI.Context;
using NimbusPulseAPI.Models;

namespace NimbusPulseAPI.Repository
{

    public interface IDeviceRepository : IRepository<Device>
    {
        Task<IEnumerable<Device>> GetDevicesByStatusAsync(string status);
        Task<IEnumerable<Device>> GetDevicesOrderedAsync(Func<IQueryable<Device>, IOrderedQueryable<Device>> orderBy);
        Task UpdateAsync(Device entity); // Add this line
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
    }

}
