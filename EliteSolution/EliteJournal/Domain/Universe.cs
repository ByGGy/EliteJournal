using System.Collections.Generic;
using System.Linq;

namespace EliteJournal.Domain
{
    public class Universe
    {
        private GalacticTradingCatalog tradingCatalog;
        private List<StarSystem> starSystems;

        public Universe()
        {
            this.tradingCatalog = GalacticTradingCatalog.CreateDefault();
            this.starSystems = new List<StarSystem>();
        }

        public void CreateStarSystem(string name)
        {
            if (!this.starSystems.Select(system => system.Name).Contains(name))
            {
                this.starSystems.Add(StarSystem.Create(name));
            }
//            else notify failure
        }

        public void RenameStarSystem(StarSystem targetSystem, string newName)
        {
            if (!this.starSystems.Select(system => system.Name).Contains(newName))
                targetSystem.Rename(newName);
        }

        public GalacticTradingCatalog TradingCatalog { get { return this.tradingCatalog; } }
        public IEnumerable<StarSystem> StarSystems { get { return this.starSystems; } }
    }
}
