using SakovichGleb.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SakovichGleb.ViewModels
{
    public class MonthViewModel
    {
        public int[,] Hours = new int[,] 
        { 
            { 0, 0, 0, 0 }, // Понедельник
            { 0, 0, 0, 0 }, // Вторник и т.д.
            { 0, 0, 0, 0 },
            { 0, 0, 0, 0 },
            { 0, 0, 0, 0 },
            { 0, 0, 0, 0 }
        };

        public int Lectures { get; set; }
        public int Practice { get; set; }
        public int Labs { get; set; }
        public int Cons { get; set; }
    }
}
