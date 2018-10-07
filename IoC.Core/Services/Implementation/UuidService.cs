using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoC.Core.Services.Implementation
{
    public class UuidService : IUuidService
    {
        public string GetUuid()
        {
            return Guid.NewGuid().ToString("N");
        }
    }
}
