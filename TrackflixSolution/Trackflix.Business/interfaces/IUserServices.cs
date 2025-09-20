using Trackflix.Business.DTOs;
using Trackflix.Entities.entities;

namespace Trackflix.Business.Services
{
    public interface IUserService
    {
        Task<User> RegisterUserAsync(UserRegisterDto dto);
        Task<string> LoginAsync(UserLoginDto dto);
        
    }
}
