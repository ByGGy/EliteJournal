using System;

namespace EliteJournal.Domain
{
    public class MarketGood
    {
        private Guid id;

        private Guid categoryId;
        private string name;
        private uint averagePrice;

        private MarketGood()
        {
            this.id = Guid.Empty;

            this.categoryId = Guid.Empty;
            this.name = string.Empty;
            this.averagePrice = uint.MinValue;
        }

        public static MarketGood Create(MarketCategory category, string name, uint averagePrice)
        {
            MarketGood newGood = new MarketGood();

            newGood.id = Guid.NewGuid();

            newGood.categoryId = category.Id;
            newGood.name = name;
            newGood.averagePrice = averagePrice;

            return newGood;
        }

        public Guid Id { get { return this.id; } }

        public Guid CategoryId { get { return this.categoryId; } }
        public string Name { get { return this.name; } }
        public uint AveragePrice { get { return this.averagePrice; } }
    }
}
