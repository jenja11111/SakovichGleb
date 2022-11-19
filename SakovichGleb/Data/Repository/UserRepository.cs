using Microsoft.EntityFrameworkCore;
using SakovichGleb.Data.Interfaces;
using SakovichGleb.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace SakovichGleb.Data.Repository
{
    public class UserRepository : IUser
    {
        private readonly AppDbContext appDbContext;

        public UserRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public IEnumerable<User> GetUsers()
        {
            return appDbContext.Users;
        }

        public void DeleteUser(User user)
        {
            appDbContext.Users.Remove(user);
            appDbContext.SaveChanges();
        }

        public User FindById(int id)
        {
            return appDbContext.Users.Single(x => x.Id == id);
        }
        public User FindByLogin(string login)
        {
            return appDbContext.Users.FirstOrDefault(u => u.Login == login);
        }
        public User FindByLoginAndPassword(string login, string password)
        {
            return appDbContext.Users.FirstOrDefault(u => u.Login == login && u.Password == password);
        }

        public int SaveUser(User user)
        {
            if (user.Id == default)
                appDbContext.Entry(user).State = EntityState.Added;
            else
                appDbContext.Entry(user).State = EntityState.Modified;
            appDbContext.SaveChanges();

            return user.Id;
        }
    }
}
