using System.Collections.Generic;
using Model;
namespace FileData
{
    public class UserService : IUserService
    {
        private FileContext fileContext = new FileContext();

        public IList<User> GetUsers()
        {
            return fileContext.Users;
        }
        public void AddUser(User user)
        {
            fileContext.Users.Add(user);
            fileContext.SaveUser();
        }
        public User ValidateUser(string username, string password)
        {
            return fileContext.ValidateUser(username, password);
        }
    }
}