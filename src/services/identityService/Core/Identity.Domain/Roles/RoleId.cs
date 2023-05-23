using Identity.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identity.Domain.Roles
{
    public class RoleId : StronglyTypedId<RoleId>
    {
        public RoleId(Guid value) : base(value)
        {
        }
    }
}
