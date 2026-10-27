using Splivo.Infrastructure.Data;
using Splivo.Module.Data.Models;

namespace Splivo.Module.Service.UserList
{
    public class UserService : IUserService
    {
        private readonly IRepository<User> _userRepository;
        public UserService(IRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }
    }
}
