using Identity.Domain.SeedWork;

namespace Identity.Domain.Permissions
{
    public class PermissionId : StronglyTypedId<PermissionId>
    {
        public PermissionId(Guid value) : base(value)
        {
        }
    }
}
