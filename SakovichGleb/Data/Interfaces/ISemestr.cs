using SakovichGleb.Data.Models;
using System.Collections.Generic;

namespace SakovichGleb.Data.Interfaces
{
    public interface ISemestr
    {
        public IEnumerable<Semestr> GetSemestrs();
        public Semestr FindById(int id);
        public int SaveSemestr(Semestr semestr);
        public void DeleteSemestr(Semestr semestr);
    }
}
