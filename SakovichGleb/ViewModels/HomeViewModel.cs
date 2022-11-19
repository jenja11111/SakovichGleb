using SakovichGleb.Data.Models;
using SakovichGleb.Data.Repository;

namespace SakovichGleb.ViewModels
{
    public class HomeViewModel
    {
        public User User { get; set; }
        public UserRepository UserRepository { get; set; }
    }
}
