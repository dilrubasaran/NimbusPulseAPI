
using AutoMapper;
using Mapster;
using NimbusPulseAPI.DTOs;
using NimbusPulseAPI.Models;

namespace NimbusPulseAPI.Mapping
{
    public class UserMapping: IRegister
    {
        public void Register(TypeAdapterConfig config)
            {
            // RegisterDTO -> User
            config.NewConfig<RegisterDTO, User>()
         
                .Map(dest => dest.CreatedAt, src => DateTime.UtcNow);
                

            // LoginDTO -> User
            config.NewConfig< LoginDTO, User>();

            // User -> RegisterDTO
            config.NewConfig< User, RegisterDTO>();

            // User -> LoginDTO
            config.NewConfig<User, LoginDTO>();
        }
    }
}

