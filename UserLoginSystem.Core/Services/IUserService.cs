
namespace UserLoginSystem.Core.Services
{
    public interface IAuthService
    {
        Task<User?> ValidateUserAsync(string username, string password);
        Task<bool> RegisterUserAsync(string username, string email, string password);
    }
}