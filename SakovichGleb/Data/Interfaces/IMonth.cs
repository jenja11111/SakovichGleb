using SakovichGleb.Data.Models;
using System.Collections.Generic;

namespace SakovichGleb.Data.Interfaces
{
    public interface IMonth
    {
        public IEnumerable<Month> GetMonths();
        public Month FindById(int id);
        public int SaveMonth(Month month);
        public void DeleteMonth(Month month);
    }
}
