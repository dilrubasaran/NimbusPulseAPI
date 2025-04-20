using NimbusPulseAPI.DTOs;
using NimbusPulseAPI.Models;
using NimbusPulseAPI.Repository;
using System.Linq.Expressions;
using Mapster;

namespace NimbusPulseAPI.Services
{

    public interface IUserService : IRepository<User>
    {
        Task<bool> RegisterAsync(RegisterDTO registerDto);
        Task<LoginDTO> LoginAsync(string email, string password);
        Task UpdateProfileAsync(int userId, ProfileUpdateDTO profileDto);
        Task UpdateThemeAndLanguageAsync(int userId, ThemeUpdateDTO themeDto);
        Task UpdateSecurityCodeAsync(int userId, SecurityCodeChangeDTO securityDto);
        Task UpdatePasswordAsync(int userId, PasswordChangeDTO passwordDTO);
    }
    public class UserService : IUserService
    {
        private readonly IRepository<User> _userRepository;
        private readonly IRepository<Settings> _settingsRepository;
     

        public UserService(IRepository<User> userRepository, IRepository<Settings> settingsRepository)
        {
            _userRepository = userRepository;
            _settingsRepository = settingsRepository;
         
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
            try
            {
                var users = await _userRepository.GetAllAsync();
                if (users.Any(u => u.Email == registerDto.Email))
                {
                    throw new Exception("Email is already in use.");
                }

                // Önce Settings oluştur
                var settings = new Settings
                {
                    Theme = "Light",
                    Language = "en",
                    SecurityCode = "0000",
                    LanguagePreference = "en",
                    NotificationPreference = "Email"
                };
                await _settingsRepository.AddAsync(settings);

                // Sonra User oluştur ve Settings ile ilişkilendir
                var user = registerDto.Adapt<User>();
                user.SettingsId = settings.Id;
                user.CreatedAt = DateTime.UtcNow;
                await _userRepository.AddAsync(user);

                // Settings'e UserId ata
                settings.UserId = user.Id;
                await _settingsRepository.UpdateAsync(settings);

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<LoginDTO> LoginAsync(string email, string password)
        {
            var users = await _userRepository.GetAllAsync();
            var user = users.FirstOrDefault(u => u.Email == email && u.Password == password);

            if (user == null)
            {
                throw new Exception("Invalid email or password.");
            }

            return user.Adapt<LoginDTO>();
        }

        public async Task UpdateProfileAsync(int userId, ProfileUpdateDTO profileDto)
        {
            var user = await _userRepository.GetByIdAsync(userId);
            if (user == null)
                throw new Exception("User not found");

            user.Name = profileDto.FirstName;
            user.SurName = profileDto.SurName;
            user.Email = profileDto.Email;
            user.PhoneNumber = profileDto.PhoneNumber;
            user.ProfilePictureUrl = profileDto.ProfilePictureUrl;

            await _userRepository.UpdateAsync(user);
        }

        public async Task UpdatePasswordAsync(int userId, PasswordChangeDTO passwordDTO)
        {
            var user = await _userRepository.GetByIdAsync(userId);
            if (user == null)
                throw new Exception("User not found");

            if (user.Password != passwordDTO.CurrentPassword)
                throw new Exception("Current password is incorrect");

            if (passwordDTO.NewPassword != passwordDTO.ConfirmNewPassword)
                throw new Exception("New passwords do not match");

            user.Password = passwordDTO.NewPassword;
            await _userRepository.UpdateAsync(user);
        }

        public async Task UpdateThemeAndLanguageAsync(int userId, ThemeUpdateDTO themeDto)
        {
            var user = await _userRepository.GetByIdAsync(userId);
            if (user == null || user.SettingsId == null)
                throw new Exception("User or settings not found");

            var settings = await _settingsRepository.GetByIdAsync(user.SettingsId.Value);
            if (settings == null)
                throw new Exception("Settings not found");

            settings.Theme = themeDto.Theme;
            settings.Language = themeDto.Language;

            await _settingsRepository.UpdateAsync(settings);
        }

        public async Task UpdateSecurityCodeAsync(int userId, SecurityCodeChangeDTO securityDto)
        {
            var user = await _userRepository.GetByIdAsync(userId);
            if (user == null || user.SettingsId == null)
                throw new Exception("User or settings not found");

            var settings = await _settingsRepository.GetByIdAsync(user.SettingsId.Value);
            if (settings == null)
                throw new Exception("Settings not found");

            if (settings.SecurityCode != securityDto.CurrentSecurityCode)
                throw new Exception("Current security code is incorrect");

            if (securityDto.NewSecurityCode != securityDto.ConfirmNewSecurityCode)
                throw new Exception("New security codes do not match");

            settings.SecurityCode = securityDto.NewSecurityCode;
            await _settingsRepository.UpdateAsync(settings);
        }

    }
}
