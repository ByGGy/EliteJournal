using System;
using System.Collections.Generic;
using System.Linq;

namespace EliteJournal.Domain
{
    public class GalacticTradingCatalog
    {
        private Guid id;

        private List<MarketCategory> categories;

        private GalacticTradingCatalog()
        {
            this.id = Guid.Empty;

            this.categories = new List<MarketCategory>();
        }

        //Based on ingame data from version 1.05
        //Legal Goods Only
        //Ordered from the Commodity Market panel (looks like alpha order, which is different than the Navigation Map)
        public static GalacticTradingCatalog CreateDefault()
        {
            GalacticTradingCatalog newCatalog = new GalacticTradingCatalog();

            newCatalog.id = Guid.NewGuid();

            newCatalog.categories.Add(MarketCategory.Create("Chemicals"));
            newCatalog.categories.Last().AddCommodity(MarketCommodity.Create("Explosives", 378));
            newCatalog.categories.Last().AddCommodity(MarketCommodity.Create("Hydrogen Fuel", 147));
            newCatalog.categories.Last().AddCommodity(MarketCommodity.Create("Mineral Oil", 259));
            newCatalog.categories.Last().AddCommodity(MarketCommodity.Create("Pesticides", 292));

            newCatalog.categories.Add(MarketCategory.Create("Consumer Items"));
            newCatalog.categories.Last().AddCommodity(MarketCommodity.Create("Clothing", 395));
            newCatalog.categories.Last().AddCommodity(MarketCommodity.Create("Consumer Technology", 7031));
            newCatalog.categories.Last().AddCommodity(MarketCommodity.Create("Domestic Appliances", 631));

            newCatalog.categories.Add(MarketCategory.Create("Foods"));
            newCatalog.categories.Last().AddCommodity(MarketCommodity.Create("Algae", 200));
            newCatalog.categories.Last().AddCommodity(MarketCommodity.Create("Animal Meat", 1460));
            newCatalog.categories.Last().AddCommodity(MarketCommodity.Create("Coffee", 1460));
            newCatalog.categories.Last().AddCommodity(MarketCommodity.Create("Fish", 493));
            newCatalog.categories.Last().AddCommodity(MarketCommodity.Create("Food Cartridges", 206));
            newCatalog.categories.Last().AddCommodity(MarketCommodity.Create("Fruit And Vegetables", 395));
            newCatalog.categories.Last().AddCommodity(MarketCommodity.Create("Grain", 275));
            newCatalog.categories.Last().AddCommodity(MarketCommodity.Create("Synthetic Meat", 324));
            newCatalog.categories.Last().AddCommodity(MarketCommodity.Create("Tea", 1646));

            newCatalog.categories.Add(MarketCategory.Create("Industrial Materials"));
            newCatalog.categories.Last().AddCommodity(MarketCommodity.Create("Polymers", 216));
            newCatalog.categories.Last().AddCommodity(MarketCommodity.Create("SemiConductors", 1029));
            newCatalog.categories.Last().AddCommodity(MarketCommodity.Create("SuperConductors", 7031));

            newCatalog.categories.Add(MarketCategory.Create("Legal Drugs"));
            newCatalog.categories.Last().AddCommodity(MarketCommodity.Create("Beer", 240));
            newCatalog.categories.Last().AddCommodity(MarketCommodity.Create("Liquor", 738));
            newCatalog.categories.Last().AddCommodity(MarketCommodity.Create("Tobacco", 5088));
            newCatalog.categories.Last().AddCommodity(MarketCommodity.Create("Wine", 324));

            newCatalog.categories.Add(MarketCategory.Create("Machinery"));
            newCatalog.categories.Last().AddCommodity(MarketCommodity.Create("Atmospheric Processors", 493));
            newCatalog.categories.Last().AddCommodity(MarketCommodity.Create("Crop Harvesters", 2378));
            newCatalog.categories.Last().AddCommodity(MarketCommodity.Create("Marine Equipment", 4474));
            newCatalog.categories.Last().AddCommodity(MarketCommodity.Create("Microbial Furnaces", 266));
            newCatalog.categories.Last().AddCommodity(MarketCommodity.Create("Mineral Extractors", 700));
            newCatalog.categories.Last().AddCommodity(MarketCommodity.Create("Power Generators", 631));
            newCatalog.categories.Last().AddCommodity(MarketCommodity.Create("Water Purifiers", 378));

            newCatalog.categories.Add(MarketCategory.Create("Medicines"));
            newCatalog.categories.Last().AddCommodity(MarketCommodity.Create("Agri-Medicines", 1154));
            newCatalog.categories.Last().AddCommodity(MarketCommodity.Create("Basic Medicines", 395));
            newCatalog.categories.Last().AddCommodity(MarketCommodity.Create("Performance Enhancers", 7031));
            newCatalog.categories.Last().AddCommodity(MarketCommodity.Create("Progenitor Cells", 7031));

            newCatalog.categories.Add(MarketCategory.Create("Metals"));
            newCatalog.categories.Last().AddCommodity(MarketCommodity.Create("Aluminium", 412));
            newCatalog.categories.Last().AddCommodity(MarketCommodity.Create("Beryllium", 8549));
            newCatalog.categories.Last().AddCommodity(MarketCommodity.Create("Cobalt", 823));
            newCatalog.categories.Last().AddCommodity(MarketCommodity.Create("Copper", 570));
            newCatalog.categories.Last().AddCommodity(MarketCommodity.Create("Gallium", 5426));
            newCatalog.categories.Last().AddCommodity(MarketCommodity.Create("Gold", 9742));
            newCatalog.categories.Last().AddCommodity(MarketCommodity.Create("Indium", 6175));
            newCatalog.categories.Last().AddCommodity(MarketCommodity.Create("Lithium", 1749));
            newCatalog.categories.Last().AddCommodity(MarketCommodity.Create("Palladium", 13527));
            newCatalog.categories.Last().AddCommodity(MarketCommodity.Create("Platinum", 18814));
            newCatalog.categories.Last().AddCommodity(MarketCommodity.Create("Silver", 5088));
            newCatalog.categories.Last().AddCommodity(MarketCommodity.Create("Tantalum", 4196));
            newCatalog.categories.Last().AddCommodity(MarketCommodity.Create("Titanium", 1154));
            newCatalog.categories.Last().AddCommodity(MarketCommodity.Create("Uranium", 2869));

            newCatalog.categories.Add(MarketCategory.Create("Minerals"));
            newCatalog.categories.Last().AddCommodity(MarketCommodity.Create("Bauxite", 216));
            newCatalog.categories.Last().AddCommodity(MarketCommodity.Create("Bertrandite", 2694));
            newCatalog.categories.Last().AddCommodity(MarketCommodity.Create("Coltan", 1550));
            newCatalog.categories.Last().AddCommodity(MarketCommodity.Create("Gallite", 2101));
            newCatalog.categories.Last().AddCommodity(MarketCommodity.Create("Indite", 2378));
            newCatalog.categories.Last().AddCommodity(MarketCommodity.Create("Lepidolite", 700));
            newCatalog.categories.Last().AddCommodity(MarketCommodity.Create("Rutile", 412));
            newCatalog.categories.Last().AddCommodity(MarketCommodity.Create("Uraninite", 1029));

            newCatalog.categories.Add(MarketCategory.Create("Technology"));
            newCatalog.categories.Last().AddCommodity(MarketCommodity.Create("Advanced Catalysers", 3055));
            newCatalog.categories.Last().AddCommodity(MarketCommodity.Create("Animal Monitors", 378));
            newCatalog.categories.Last().AddCommodity(MarketCommodity.Create("Aquaponic Systems", 349));
            newCatalog.categories.Last().AddCommodity(MarketCommodity.Create("Auto Fabricators", 3937));
            newCatalog.categories.Last().AddCommodity(MarketCommodity.Create("Bioreducing Lichen", 1089));
            newCatalog.categories.Last().AddCommodity(MarketCommodity.Create("Computer Components", 631));
            newCatalog.categories.Last().AddCommodity(MarketCommodity.Create("H.E Suits", 349));
            newCatalog.categories.Last().AddCommodity(MarketCommodity.Create("Land Enrichment Systems", 5088));
            newCatalog.categories.Last().AddCommodity(MarketCommodity.Create("Resonating Separators", 6175));
            newCatalog.categories.Last().AddCommodity(MarketCommodity.Create("Robotics", 1976));

            newCatalog.categories.Add(MarketCategory.Create("Textiles"));
            newCatalog.categories.Last().AddCommodity(MarketCommodity.Create("Leather", 240));
            newCatalog.categories.Last().AddCommodity(MarketCommodity.Create("Natural Fabrics", 493));
            newCatalog.categories.Last().AddCommodity(MarketCommodity.Create("Synthetic Fabrics", 252));

            newCatalog.categories.Add(MarketCategory.Create("Waste"));
            newCatalog.categories.Last().AddCommodity(MarketCommodity.Create("Biowaste", 74));
            newCatalog.categories.Last().AddCommodity(MarketCommodity.Create("Chemical Waste", 79));
            newCatalog.categories.Last().AddCommodity(MarketCommodity.Create("Scrap", 96));

            newCatalog.categories.Add(MarketCategory.Create("Weapons"));
            newCatalog.categories.Last().AddCommodity(MarketCommodity.Create("Non-Lethal Weapons", 1976));
            newCatalog.categories.Last().AddCommodity(MarketCommodity.Create("Personal Weapons", 4474));
            newCatalog.categories.Last().AddCommodity(MarketCommodity.Create("Reactive Armour", 2235));

            return newCatalog;
        }

        public IEnumerable<MarketCategory> Categories { get { return this.categories; } }
    }
}
