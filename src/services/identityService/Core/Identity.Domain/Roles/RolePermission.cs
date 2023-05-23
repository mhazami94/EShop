using Identity.Domain.Permissions;
using Identity.Domain.SeedWork;

namespace Identity.Domain.Roles
{
    public class RolePermission : Entity<Guid>
    {
        private RolePermission(RoleId roleId, PermissionId permissionId)
        {
            Id = Guid.NewGuid();
            RoleId = roleId;
            PermissionId = permissionId;
        }

        public RoleId RoleId { get; private set; }
        public PermissionId PermissionId { get; private set; }

        public static RolePermission CreateNew(RoleId roleId, PermissionId permissionId)
        {
            return new RolePermission(roleId, permissionId);
        }
    }
}
