using EliteJournal.Domain;
using Infrastructure;
using System.Collections.Generic;
using System.Linq;

namespace EliteJournal.Presentation
{
    public class CatalogViewModel : ViewModel
    {
        private List<MarketCategory> categoryCollection;
        public List<MarketCategory> CategoryCollection
        {
            get { return this.categoryCollection; }
            set
            {
                if (this.categoryCollection != value)
                {
                    this.categoryCollection = value;
                    NotifyPropertyChanged("CategoryCollection");
                }
            }
        }

        public CatalogViewModel()
        {
            this.CategoryCollection = EasyLocator.Instance.Universe.TradingCatalog.Categories.ToList();
        }
    }
}
