using AutoMapper;
using NimbusPulseAPI.DTOs;
using NimbusPulseAPI.Models;
using NimbusPulseAPI.Repository;
using System.Linq.Expressions;

namespace NimbusPulseAPI.Services
{

    public interface IUserService : IRepository<User>
    {
        Task<bool> RegisterAsync(RegisterDTO registerDto);
        Task<LoginDTO> LoginAsync(string email, string password);
    }
    public class UserService : IUserService
    {
        private readonly IRepository<User> _userRepository;
        private readonly IMapper _mapper;

        public UserService(IRepository<User> userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        // IRepository CRUD metotlarının implementasyonu
        public async Task<IQueryable<User>> GetAllAsync()
        {
            return await _userRepository.GetAllAsync();
        }

        public async Task<User?> GetByIdAsync(int id)
        {
            return await _userRepository.GetByIdAsync(id);
        }

        public async Task<IQueryable<User>> FindAsync(Expression<Func<User, bool>> predicate)
        {
            return await _userRepository.FindAsync(predicate);
        }

        public async Task AddAsync(User entity)
        {
            await _userRepository.AddAsync(entity);
        }

        public async Task UpdateAsync(User entity)
        {
            await _userRepository.UpdateAsync(entity);
        }

        public async Task DeleteAsync(User entity)
        {
            await _userRepository.DeleteAsync(entity);
        }

        // User-specific methods
        public async Task<bool> RegisterAsync(RegisterDTO registerDto)
        {
            var users = await _userRepository.GetAllAsync();
            if (users.Any(u => u.Email == registerDto.Email))
            {
                throw new Exception("Email is already in use.");
            }

            var user = _mapper.Map<User>(registerDto);
            await _userRepository.AddAsync(user);
            return true;
        }

        public async Task<LoginDTO> LoginAsync(string email, string password)
        {
            var users = await _userRepository.GetAllAsync();
            var user = users.FirstOrDefault(u => u.Email == email && u.Password == password);

            if (user == null)
            {
                throw new Exception("Invalid email or password.");
            }

            return _mapper.Map<LoginDTO>(user);
        }

        

    }
}
