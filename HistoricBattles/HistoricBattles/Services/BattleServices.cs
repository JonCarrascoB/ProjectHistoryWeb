using HistoricBattles.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HistoricBattles.Models;


namespace HistoricBattles.Services
{
    public class BattleServices
    {
        private readonly ApplicationDbContext _context;

        public BattleServices(ApplicationDbContext context)
        {
            _context = context;
        }
        public List<Regiment> GetRegimentsDB(int battleId)
        {
            List<Regiment> regiments = _context.Regiments.Where(x=>x.BattleId == battleId).ToList();
            return regiments;
        }
        public List<Battle> GetBattlesBD()
        {
            List<Battle> battles = _context.Battles.ToList();
            return battles;
        }
    }
}
