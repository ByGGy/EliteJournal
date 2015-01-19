using EliteJournal.Domain;
using Infrastructure;

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

        private GalacticTradingCatalog catalog;

        private EasyLocator()
        {
            this.news = new MessageBus();

            this.catalog = GalacticTradingCatalog.CreateDefault();
        }

        public MessageBus News { get { return this.news; } }

        public GalacticTradingCatalog Catalog { get { return this.catalog; } }
    }
}
