using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HistoricBattles.Models
{
    public class Stage
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string DescriptionG { get; set; }
        public string DescriptionE1 { get; set; }
        public string DescriptionE2 { get; set; }
        public List<Regiment> Regiments { get; set; }
        public int BattleId { get; set; }
    }
}
