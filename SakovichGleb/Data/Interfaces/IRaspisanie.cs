using SakovichGleb.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SakovichGleb.Data.Interfaces
{
    public interface IRaspisanie
    {
        public IEnumerable<Raspisanie> GetRaspisanie();
        public Raspisanie FindByUserId(int id);
        public int SaveRaspisanie(Raspisanie raspisanie);
        public void DeleteRaspisanie(Raspisanie raspisanie);
    }
}
