using SakovichGleb.Data.Models;
using System.Collections.Generic;

namespace SakovichGleb.Data.Interfaces
{
    public interface INHours
    {
        public IEnumerable<NHours> GetNHourses();
        public NHours FindById(int id);
        public int SaveNHours(NHours nHours);
        public void DeleteNHours(NHours nHours);
    }
}
