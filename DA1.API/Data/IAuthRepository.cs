using System.Threading.Tasks;
using DA1.API.Models;

namespace DA1.API.Data
{
    public interface IAuthRepository
    {
         Task<User> Register(User user, string password);
         Task<User> Login(string username, string password);
         Task<User> UserExists(string username);
    }
}