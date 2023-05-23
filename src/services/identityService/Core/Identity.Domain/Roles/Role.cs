using Identity.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identity.Domain.Roles
{
    public sealed class Role : AggregateRoot<RoleId>
    {
        private Role(RoleId roleId, string title)
        {
            RoleId = roleId;
            Title = title;
        }
        private Role() { }
        public string Title { get; private set; }
        public RoleId RoleId { get; }

        public static Role CreateNew(string title)
        {
            if (string.IsNullOrEmpty(title))
                throw new ArgumentNullException("title can not be null");

            var roleId = new RoleId(Guid.NewGuid());
            return new Role(roleId, title);
        }
    }
}
