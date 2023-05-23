using Identity.Domain.Roles;
using Identity.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identity.Domain.Users
{
    public class UserRole : Entity<Guid>
    {
        private UserRole(UserId userId, RoleId roleId)
        {
            Id = Guid.NewGuid();
            UserId = userId;
            RoleId = roleId;
        }

        public UserId UserId { get; private set; }
        public RoleId RoleId { get; private set; }

        public static UserRole CreateNew(UserId userId, RoleId roleId)
        {
            return new UserRole(userId, roleId);
        }
    }
}
