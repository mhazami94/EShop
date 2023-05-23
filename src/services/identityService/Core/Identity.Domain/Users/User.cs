using Identity.Domain.SeedWork;
using Mhazami.Utility;

namespace Identity.Domain.Users
{
    public class User : AggregateRoot<UserId>
    {
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Username { get; private set; }
        public string Password { get; private set; }
        public DateTime RegisterDate { get; private set; } = DateTime.Now;

        public static User CreateNew(string name, string email, string username, string password)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentNullException("Name can not be null");
            if (string.IsNullOrEmpty(email))
                throw new ArgumentNullException("email can not be null");
            if (!Utils.IsEmail(email))
                throw new ArgumentNullException("Email is invalid");
            if (string.IsNullOrEmpty(username))
                throw new ArgumentNullException("username can not be null");
            if (string.IsNullOrEmpty(password))
                throw new ArgumentNullException("password can not be null");

            var userId = new UserId(Guid.NewGuid());
            return new User(userId, name, email, username, password);
        }
        private User(UserId userId, string name, string email, string username, string password)
        {
            Id = userId;
            Name = name;
            Email = email;
            Username = username;
            Password = password;
            RegisterDate = DateTime.Now;
        }
        private User() { }
    }
}
