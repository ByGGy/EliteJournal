using EliteJournal.Domain;
using Infrastructure;
using System.Linq;

namespace EliteJournal
{
    public sealed class EasyLocator
    {
        private static readonly EasyLocator instance = new EasyLocator();

        public static EasyLocator Instance
        {
            get
            {
                return instance;
            }
        }

        private MessageBus news;
        private Universe universe;    

        private EasyLocator()
        {
            this.news = new MessageBus();

            this.universe = new Universe();
            this.universe.CreateStarSystem("Neto");
            this.universe.StarSystems.Last().CreateBase("Ising Vision", SpaceBase.BaseType.Station, 650, this.universe.TradingCatalog);
        }

        public MessageBus News { get { return this.news; } }

        public Universe Universe { get { return this.universe; } }
    }
}
