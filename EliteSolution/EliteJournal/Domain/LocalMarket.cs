using System;

namespace EliteJournal.Domain
{
    //TODO : Add TradingEntry class
    public class LocalMarket
    {
        private Guid id;

        private LocalMarket()
        {
            this.id = Guid.Empty;
        }

        public static LocalMarket Create()
        {
            LocalMarket newMarket = new LocalMarket();

            newMarket.id = Guid.NewGuid();

            return newMarket;
        }
    }
}
