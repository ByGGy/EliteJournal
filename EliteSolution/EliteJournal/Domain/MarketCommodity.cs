using System;

namespace EliteJournal.Domain
{
    public class MarketCommodity
    {
        private Guid id;

        private string name;
        private uint averagePrice;

        private MarketCommodity()
        {
            this.id = Guid.Empty;

            this.name = string.Empty;
            this.averagePrice = uint.MinValue;
        }

        public static MarketCommodity Create(string name, uint averagePrice)
        {
            MarketCommodity newCommodity = new MarketCommodity();

            newCommodity.id = Guid.NewGuid();

            newCommodity.name = name;
            newCommodity.averagePrice = averagePrice;

            return newCommodity;
        }

        public Guid Id { get { return this.id; } }

        public string Name { get { return this.name; } }
        public uint AveragePrice { get { return this.averagePrice; } }
    }
}
