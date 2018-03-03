
using System.Threading.Tasks;
using WaifuDatingApp.API.Models;

namespace WaifuDatingApp.API.Data
{
    public interface IAuthRepository
    {
        Task<User> Register(User user, string pass);
        Task<User> LoginAsync(string username, string pass);
        Task<bool> UserExists(string username);
    }
}
