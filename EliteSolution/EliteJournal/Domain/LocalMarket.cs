using System;
using System.Collections.Generic;
using System.Linq;

namespace EliteJournal.Domain
{
    public class LocalMarket
    {
        private Guid id;

        private List<MarketOrder> orders;

        private LocalMarket()
        {
            this.id = Guid.Empty;

            this.orders = new List<MarketOrder>();
        }

        public static LocalMarket Create()
        {
            LocalMarket newMarket = new LocalMarket();

            newMarket.id = Guid.NewGuid();

            return newMarket;
        }

        //TODO : Ability to create an already partially populated market based on SpaceBase Economy
        public static LocalMarket Create(GalacticTradingCatalog catalog)
        {
            LocalMarket newMarket = Create();

            catalog.Categories.SelectMany(category => category.Commodities).ToList().ForEach(commodity =>
            {
                newMarket.orders.Add(new MarketOrder(MarketOrder.OrderType.Supply, commodity, 0, commodity.AveragePrice));    
            });

            return newMarket;
        }

        public IEnumerable<MarketOrder> Orders { get { return this.orders; } }
    }
}
