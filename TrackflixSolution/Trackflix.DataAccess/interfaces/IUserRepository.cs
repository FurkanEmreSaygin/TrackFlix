using Trackflix.DataAccess.interfaces;
using Trackflix.Entities.entities;

namespace Trackflix.DataAccess.interfaces
{
    public interface IUserRepository : IRepository<User>
    {
        Task<User?> GetByEmailAsync(string email);
    }
}
