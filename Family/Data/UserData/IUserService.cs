using System.Threading.Tasks;
using Family_Management.Models;

namespace Family.Data.UsersData
{
    public interface IUserService
    {
        Task<User> ValidateUser(string UserName, string Password);
    }
}