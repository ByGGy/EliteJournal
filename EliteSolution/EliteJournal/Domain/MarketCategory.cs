using System;
using System.Collections.Generic;

namespace EliteJournal.Domain
{
    public class MarketCategory
    {
        private Guid id;

        private string name;
        private List<MarketCommodity> commodities;

        private MarketCategory()
        {
            this.id = Guid.Empty;

            this.name = string.Empty;
            this.commodities =new List<MarketCommodity>();
        }

        public static MarketCategory Create(string name)
        {
            MarketCategory newCategory = new MarketCategory();

            newCategory.id = Guid.NewGuid();

            newCategory.name = name;

            return newCategory;
        }

        public Guid Id { get { return this.id; } }

        public string Name { get { return this.name; } }
        public IEnumerable<MarketCommodity> Commodities { get { return this.commodities; } }

        internal void AddCommodity(MarketCommodity commodity)
        {
            if (!this.commodities.Contains(commodity))
                this.commodities.Add(commodity);
        }
    }
}
