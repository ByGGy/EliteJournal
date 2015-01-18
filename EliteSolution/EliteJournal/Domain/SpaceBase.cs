using System;

namespace EliteJournal.Domain
{
    //TODO : Add Governement & Allegiance data
    public class SpaceBase
    {
        private Guid id;

        private string name;
        private uint distanceFromStar;  //in Ls

        private LocalMarket market;

        private SpaceBase()
        {
            this.id = Guid.Empty;

            this.name = string.Empty;
            this.distanceFromStar = uint.MinValue;

            this.market = LocalMarket.Create();
        }

        public static SpaceBase Create(string name)
        {
            SpaceBase newBase = new SpaceBase();

            newBase.id = Guid.NewGuid();

            newBase.name = name;

            return newBase;
        }
    }
}
