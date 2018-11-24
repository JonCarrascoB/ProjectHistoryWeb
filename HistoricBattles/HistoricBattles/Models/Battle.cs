using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HistoricBattles.Models
{
    public class Battle
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Localization { get; set; }
        public int Year { get; set; }
        public List<Stage> Stages { get; set; }
        
    }
}
