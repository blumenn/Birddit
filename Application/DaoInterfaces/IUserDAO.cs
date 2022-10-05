using Shared.Models;

namespace Application.DaoInterfaces;

public interface IUserDAO
{
    Task<User> CreateAsync(User user);
    Task<User?> GetByUsernameAsync(string userName);
}