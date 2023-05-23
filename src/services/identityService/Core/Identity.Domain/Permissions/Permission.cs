using Identity.Domain.SeedWork;

namespace Identity.Domain.Permissions
{
    public sealed class Permission : AggregateRoot<PermissionId>
    {
        private Permission(PermissionId permissionId, string title, string displayTitle)
        {
            PermissionId = permissionId;
            Title = title;
            DisplayTitle = displayTitle;
        }
        private Permission() { }

        public string Title { get; private set; }
        public string DisplayTitle { get; private set; }
        public PermissionId PermissionId { get; }

        public static Permission CreateNew(string title, string displayTitle)
        {
            if (string.IsNullOrEmpty(title))
                throw new ArgumentNullException("title can not be null");
            if (string.IsNullOrEmpty(displayTitle))
                throw new ArgumentNullException("Display title can not be null");

            var permissionId = new PermissionId(Guid.NewGuid());
            return new Permission(permissionId, title, displayTitle);
        }
    }
}
