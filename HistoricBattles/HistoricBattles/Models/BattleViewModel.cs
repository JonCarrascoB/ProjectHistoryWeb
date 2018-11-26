using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HistoricBattles.Models
{
    public class BattleViewModel
    {
        public int BattleId { get; set; }
        public List<Stage> Stages { get; set; }
        public string Image { get; set; }

    }
}
