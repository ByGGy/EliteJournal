using System;
using System.Collections.Generic;
using System.Linq;

namespace EliteJournal.Domain
{
    public class StarSystem
    {
        private Guid id;

        private string name;
        private List<SpaceBase> bases;

        private StarSystem()
        {
            this.id = Guid.Empty;

            this.name = string.Empty;
            this.bases = new List<SpaceBase>();
        }

        public static StarSystem Create(string name)
        {
            StarSystem newSystem = new StarSystem();

            newSystem.id = Guid.NewGuid();

            newSystem.name = name;

            return newSystem;
        }

        public string Name { get { return this.name; } }
        public IEnumerable<SpaceBase> Bases { get { return this.bases; } }

        internal void CreateBase(string name, SpaceBase.BaseType type, uint distanceFromStar, GalacticTradingCatalog tradingCatalog)
        {
            if (!this.bases.Select(spaceBase => spaceBase.Name).Contains(name))
            {
                this.bases.Add(SpaceBase.Create(name, type, distanceFromStar, tradingCatalog));   
            }
//            else notify failure
        }
    }
}
