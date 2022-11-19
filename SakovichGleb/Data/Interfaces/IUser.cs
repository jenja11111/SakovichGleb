using SakovichGleb.Data.Models;
using System.Collections.Generic;

namespace SakovichGleb.Data.Interfaces
{
    public interface IUser
    {
        public IEnumerable<User> GetUsers();
        public User FindById(int id);
        public int SaveUser(User user);
        public void DeleteUser(User user);
        public User FindByLogin(string login);
        public User FindByLoginAndPassword(string login, string password);
    }
}
