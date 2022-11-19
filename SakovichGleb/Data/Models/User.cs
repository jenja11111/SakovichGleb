using System.Collections.Generic;

namespace SakovichGleb.Data.Models
{
    public class User
    {
        public int Id { set; get; }
        public string Login { set; get; }
        public string Password { set; get; }
        public string Surname { set; get; }
        public string FName { set; get; }
        public string LName { set; get; }
        public List<Semestr> Semestrs { set; get; }
    }
}
