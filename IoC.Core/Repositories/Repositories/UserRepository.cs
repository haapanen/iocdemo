using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoC.Core.Repositories.Repositories
{
    // Should be in a separate project but I'll include here to simplify
    public class UserRepository : IUserRepository
    {
        public User GetUser()
        {
            return new User
            {
                Name = "Donald Duck"
            };
        }
    }
}
