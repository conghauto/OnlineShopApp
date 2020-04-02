using System.Threading.Tasks;
using OnlineShop.API.Models;

namespace OnlineShop.API.Data
{
    public interface IAuthRepository
    {
         Task<User> Register(User customer, string password);
         Task<User> Login(string username,string password);
         Task<bool> UserExists(string username);
    }
}