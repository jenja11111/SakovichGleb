using System.Collections.Generic;

namespace SakovichGleb.Data.Models
{
    public class Semestr
    {
        public int Id { get; set; }
        public byte NSemestr { get; set; } // 1 или 2
        public List<Month> Months { get; set; } // 
        public int IdUser { get; set; }
    }
}
