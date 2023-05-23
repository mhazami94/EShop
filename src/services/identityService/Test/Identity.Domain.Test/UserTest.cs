using Identity.Domain.Users;
using System.Xml.Linq;

namespace Identity.Domain.Test
{
    public class UserTest
    {

        [Theory]
        [InlineData("", "test@gmail.com", "test", "123")]
        [InlineData("test", "test@gmail.com", "", "123")]
        [InlineData("test", "test@gmail.com", "test", "")]
        [InlineData("test", "", "test", "123")]
        public void Create_New_Validation(string name, string email, string username, string password)
        {
            Assert.Throws<ArgumentNullException>(() => User.CreateNew(name, email, username, password));
        }

        [Theory]
        [InlineData("")]
        [InlineData("testgmail.com")]
        [InlineData("test@gmailcom")]
        [InlineData("test@gmail")]
        [InlineData("123")]
        public void User_Email_Validation(string email)
        {
            Assert.Throws<ArgumentNullException>(() => User.CreateNew("test", email, "test", "123"));
        }
    }
}