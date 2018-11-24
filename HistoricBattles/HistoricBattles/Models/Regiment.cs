using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HistoricBattles.Models
{
    public class Regiment
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Country { get; set; }
        public string Image { get; set; }
        public int PosX { get; set; }
        public int PosY { get; set; }
    }
}
