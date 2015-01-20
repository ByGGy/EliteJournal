using System;

namespace EliteJournal.Domain
{
    //TODO : Add Governement, Allegiance and Economy data
    public class SpaceBase
    {
        public enum BaseType
        {
            Station,
            Outpost
        }

        private Guid id;

        private string name;
        private BaseType type;
        private uint distanceFromStar;  //in Ls

        private LocalMarket market;

        private SpaceBase()
        {
            this.id = Guid.Empty;

            this.name = string.Empty;
            this.type = BaseType.Station;
            this.distanceFromStar = uint.MinValue;

            this.market = LocalMarket.Create();
        }

        public static SpaceBase Create(string name, BaseType type, uint distanceFromStar)
        {
            SpaceBase newBase = new SpaceBase();

            newBase.id = Guid.NewGuid();

            newBase.name = name;
            newBase.type = type;
            newBase.distanceFromStar = distanceFromStar;

            return newBase;
        }
    }
}
