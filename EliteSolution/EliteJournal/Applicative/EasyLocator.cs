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

        private EasyLocator()
        {
            this.news = new MessageBus();
        }

        public MessageBus News
        {
            get { return this.news; }
        }
    }
}
