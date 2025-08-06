
namespace UserLoginSystem.Core.Services
{
    public class AuthService : IAuthService
    {
        private readonly AppDbContext _context;

        public AuthService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<User?> ValidateUserAsync(string username, string password)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Username == username);
            if (user != null && BCrypt.Net.BCrypt.Verify(password, user.PasswordHash))
            {
                return user;
            }
            return null;
        }

        public async Task<bool> RegisterUserAsync(string username, string email, string password)
        {
            if (await _context.Users.AnyAsync(u => u.Username == username || u.Email == email))
            {
                return false; // Kullanıcı zaten var
            }

            var passwordHash = BCrypt.Net.BCrypt.HashPassword(password);
            var user = new User { Username = username, Email = email, PasswordHash = passwordHash, Role = "User" };

            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}