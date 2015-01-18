using System;
using System.Collections.Generic;

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
    }
}
