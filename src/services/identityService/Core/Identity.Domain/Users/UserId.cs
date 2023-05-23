using Identity.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identity.Domain.Users
{
    public sealed class UserId : StronglyTypedId<UserId>
    {
        public UserId(Guid value) : base(value) { }
    }
}
