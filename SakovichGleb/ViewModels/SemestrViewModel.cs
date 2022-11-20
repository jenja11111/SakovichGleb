using SakovichGleb.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SakovichGleb.ViewModels
{
    public class SemestrViewModel
    {
        public int Id { get; set; }
        public byte NSemestr { get; set; } // 1 или 2
        public List<Month> Months { get; set; } 
        public int IdUser { get; set; }
        public User User { get; set; }
        public SemestrViewModel(User user, byte nSemestr)
        {
            this.NSemestr = nSemestr;
            this.User = user;
            IdUser = user.Id;
        }
    }
}
