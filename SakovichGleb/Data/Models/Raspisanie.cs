using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SakovichGleb.Data.Models
{
    public class Raspisanie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int idUser { get; set; }
        public User User { get; set; }
    }
}
