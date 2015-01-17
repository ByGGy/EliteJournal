using System;

namespace EliteJournal.Domain
{
    public class MarketCategory
    {
        private Guid id;

        private string name;

        private MarketCategory()
        {
            this.id = Guid.Empty;

            this.name = string.Empty;
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
    }
}
