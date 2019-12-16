using System.Threading.Tasks;
using WorldRecipes.Models;

namespace WorldRecipes.Data
{
    public interface IAuthRepository
    {
        Task<User> Register(User user, string password);
        Task<User> Login(string username, string password);

    }
}