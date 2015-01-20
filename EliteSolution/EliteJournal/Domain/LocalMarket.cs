using System;
using System.Collections.Generic;

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

        //TODO : Ability to create an already partially populated market based on SpaceBase Economy
        public static LocalMarket Create()
        {
            LocalMarket newMarket = new LocalMarket();

            newMarket.id = Guid.NewGuid();

            return newMarket;
        }
    }
}
