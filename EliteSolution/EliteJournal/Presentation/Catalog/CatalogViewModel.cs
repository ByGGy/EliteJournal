using EliteJournal.Domain;
using Infrastructure;
using System.Collections.ObjectModel;
using System.Linq;

namespace EliteJournal.Presentation
{
    public class CatalogViewModel : ViewModel
    {
        //TODO : Display in a ListView, grouped by MarketCategory and improve the template
        private ObservableCollection<MarketCommodity> commodityCollection;
        public ObservableCollection<MarketCommodity> CommodityCollection
        {
            get { return this.commodityCollection; }
            set
            {
                if (this.commodityCollection != value)
                {
                    this.commodityCollection = value;
                    NotifyPropertyChanged("CommodityCollection");
                }
            }
        }

        public CatalogViewModel()
        {
            this.CommodityCollection = new ObservableCollection<MarketCommodity>(EasyLocator.Instance.Catalog.Commodities.ToList());
        }
    }
}
