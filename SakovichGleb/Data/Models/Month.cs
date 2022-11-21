using System.Collections.Generic;

namespace SakovichGleb.Data.Models
{
    public class Month
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<NHours> NHourses { get; set; }
        public int IdSemestr { get; set; }
    }
}
