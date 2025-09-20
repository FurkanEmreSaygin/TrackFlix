using AutoMapper;
using Trackflix.Business.DTOs;
using Trackflix.Entities.entities;

namespace Trackflix.Business.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // RegisterDto -> User (password handled in service, map fields other than password)
            CreateMap<UserRegisterDto, User>()
                .ForMember(dest => dest.PasswordHash, opt => opt.Ignore())
                .ForMember(dest => dest.Role, opt => opt.Ignore());

            // User -> UserDto (response)
            CreateMap<User, UserDto>()
                .ForMember(d => d.Role, o => o.MapFrom(s => s.Role.RoleName));
        }
    }
}
