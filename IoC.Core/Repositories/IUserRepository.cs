using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoC.Core.Repositories
{
    public interface IUserRepository
    {
        User GetUser();
    }
}
