using System.Collections.Generic;
using Model;
namespace FileData
{
    public interface IUserService
    {
        public IList<User> GetUsers();
        public void AddUser(User user);
        public User ValidateUser(string username, string password);
    }
}