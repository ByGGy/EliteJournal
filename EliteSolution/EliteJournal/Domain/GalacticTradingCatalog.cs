using System;
using System.Collections.Generic;
using System.Linq;

namespace EliteJournal.Domain
{
    public class GalacticTradingCatalog
    {
        private Guid id;

        private List<MarketCategory> categories;
        private List<MarketCommodity> commodities;

        private GalacticTradingCatalog()
        {
            this.id = Guid.Empty;

            this.categories = new List<MarketCategory>();
            this.commodities = new List<MarketCommodity>();
        }

        //Based on ingame data from version 1.05
        //Legal Goods Only
        //Ordered from the Commodity Market panel (looks like alpha order, which is different than the Navigation Map)
        public static GalacticTradingCatalog CreateDefault()
        {
            GalacticTradingCatalog newCatalog = new GalacticTradingCatalog();

            newCatalog.id = Guid.NewGuid();

            newCatalog.categories.Add(MarketCategory.Create("Chemicals"));
            newCatalog.commodities.Add(MarketCommodity.Create(newCatalog.categories.Last(), "Explosives", 378));
            newCatalog.commodities.Add(MarketCommodity.Create(newCatalog.categories.Last(), "Hydrogen Fuel", 147));
            newCatalog.commodities.Add(MarketCommodity.Create(newCatalog.categories.Last(), "Mineral Oil", 259));
            newCatalog.commodities.Add(MarketCommodity.Create(newCatalog.categories.Last(), "Pesticides", 292));

            newCatalog.categories.Add(MarketCategory.Create("Consumer Items"));
            newCatalog.commodities.Add(MarketCommodity.Create(newCatalog.categories.Last(), "Clothing", 395));
            newCatalog.commodities.Add(MarketCommodity.Create(newCatalog.categories.Last(), "Consumer Technology", 7031));
            newCatalog.commodities.Add(MarketCommodity.Create(newCatalog.categories.Last(), "Domestic Appliances", 631));

            newCatalog.categories.Add(MarketCategory.Create("Foods"));
            newCatalog.commodities.Add(MarketCommodity.Create(newCatalog.categories.Last(), "Algae", 200));
            newCatalog.commodities.Add(MarketCommodity.Create(newCatalog.categories.Last(), "Animal Meat", 1460));
            newCatalog.commodities.Add(MarketCommodity.Create(newCatalog.categories.Last(), "Coffee", 1460));
            newCatalog.commodities.Add(MarketCommodity.Create(newCatalog.categories.Last(), "Fish", 493));
            newCatalog.commodities.Add(MarketCommodity.Create(newCatalog.categories.Last(), "Food Cartridges", 206));
            newCatalog.commodities.Add(MarketCommodity.Create(newCatalog.categories.Last(), "Fruit And Vegetables", 395));
            newCatalog.commodities.Add(MarketCommodity.Create(newCatalog.categories.Last(), "Grain", 275));
            newCatalog.commodities.Add(MarketCommodity.Create(newCatalog.categories.Last(), "Synthetic Meat", 324));
            newCatalog.commodities.Add(MarketCommodity.Create(newCatalog.categories.Last(), "Tea", 1646));

            newCatalog.categories.Add(MarketCategory.Create("Industrial Materials"));
            newCatalog.commodities.Add(MarketCommodity.Create(newCatalog.categories.Last(), "Polymers", 216));
            newCatalog.commodities.Add(MarketCommodity.Create(newCatalog.categories.Last(), "SemiConductors", 1029));
            newCatalog.commodities.Add(MarketCommodity.Create(newCatalog.categories.Last(), "SuperConductors", 7031));

            newCatalog.categories.Add(MarketCategory.Create("Legal Drugs"));
            newCatalog.commodities.Add(MarketCommodity.Create(newCatalog.categories.Last(), "Beer", 240));
            newCatalog.commodities.Add(MarketCommodity.Create(newCatalog.categories.Last(), "Liquor", 738));
            newCatalog.commodities.Add(MarketCommodity.Create(newCatalog.categories.Last(), "Tobacco", 5088));
            newCatalog.commodities.Add(MarketCommodity.Create(newCatalog.categories.Last(), "Wine", 324));

            newCatalog.categories.Add(MarketCategory.Create("Machinery"));
            newCatalog.commodities.Add(MarketCommodity.Create(newCatalog.categories.Last(), "Atmospheric Processors", 493));
            newCatalog.commodities.Add(MarketCommodity.Create(newCatalog.categories.Last(), "Crop Harvesters", 2378));
            newCatalog.commodities.Add(MarketCommodity.Create(newCatalog.categories.Last(), "Marine Equipment", 4474));
            newCatalog.commodities.Add(MarketCommodity.Create(newCatalog.categories.Last(), "Microbial Furnaces", 266));
            newCatalog.commodities.Add(MarketCommodity.Create(newCatalog.categories.Last(), "Mineral Extractors", 700));
            newCatalog.commodities.Add(MarketCommodity.Create(newCatalog.categories.Last(), "Power Generators", 631));
            newCatalog.commodities.Add(MarketCommodity.Create(newCatalog.categories.Last(), "Water Purifiers", 378));

            newCatalog.categories.Add(MarketCategory.Create("Medicines"));
            newCatalog.commodities.Add(MarketCommodity.Create(newCatalog.categories.Last(), "Agri-Medicines", 1154));
            newCatalog.commodities.Add(MarketCommodity.Create(newCatalog.categories.Last(), "Basic Medicines", 395));
            newCatalog.commodities.Add(MarketCommodity.Create(newCatalog.categories.Last(), "Performance Enhancers", 7031));
            newCatalog.commodities.Add(MarketCommodity.Create(newCatalog.categories.Last(), "Progenitor Cells", 7031));

            newCatalog.categories.Add(MarketCategory.Create("Metals"));
            newCatalog.commodities.Add(MarketCommodity.Create(newCatalog.categories.Last(), "Aluminium", 412));
            newCatalog.commodities.Add(MarketCommodity.Create(newCatalog.categories.Last(), "Beryllium", 8549));
            newCatalog.commodities.Add(MarketCommodity.Create(newCatalog.categories.Last(), "Cobalt", 823));
            newCatalog.commodities.Add(MarketCommodity.Create(newCatalog.categories.Last(), "Copper", 570));
            newCatalog.commodities.Add(MarketCommodity.Create(newCatalog.categories.Last(), "Gallium", 5426));
            newCatalog.commodities.Add(MarketCommodity.Create(newCatalog.categories.Last(), "Gold", 9742));
            newCatalog.commodities.Add(MarketCommodity.Create(newCatalog.categories.Last(), "Indium", 6175));
            newCatalog.commodities.Add(MarketCommodity.Create(newCatalog.categories.Last(), "Lithium", 1749));
            newCatalog.commodities.Add(MarketCommodity.Create(newCatalog.categories.Last(), "Palladium", 13527));
            newCatalog.commodities.Add(MarketCommodity.Create(newCatalog.categories.Last(), "Platinum", 18814));
            newCatalog.commodities.Add(MarketCommodity.Create(newCatalog.categories.Last(), "Silver", 5088));
            newCatalog.commodities.Add(MarketCommodity.Create(newCatalog.categories.Last(), "Tantalum", 4196));
            newCatalog.commodities.Add(MarketCommodity.Create(newCatalog.categories.Last(), "Titanium", 1154));
            newCatalog.commodities.Add(MarketCommodity.Create(newCatalog.categories.Last(), "Uranium", 2869));

            newCatalog.categories.Add(MarketCategory.Create("Minerals"));
            newCatalog.commodities.Add(MarketCommodity.Create(newCatalog.categories.Last(), "Bauxite", 216));
            newCatalog.commodities.Add(MarketCommodity.Create(newCatalog.categories.Last(), "Bertrandite", 2694));
            newCatalog.commodities.Add(MarketCommodity.Create(newCatalog.categories.Last(), "Coltan", 1550));
            newCatalog.commodities.Add(MarketCommodity.Create(newCatalog.categories.Last(), "Gallite", 2101));
            newCatalog.commodities.Add(MarketCommodity.Create(newCatalog.categories.Last(), "Indite", 2378));
            newCatalog.commodities.Add(MarketCommodity.Create(newCatalog.categories.Last(), "Lepidolite", 700));
            newCatalog.commodities.Add(MarketCommodity.Create(newCatalog.categories.Last(), "Rutile", 412));
            newCatalog.commodities.Add(MarketCommodity.Create(newCatalog.categories.Last(), "Uraninite", 1029));

            newCatalog.categories.Add(MarketCategory.Create("Technology"));
            newCatalog.commodities.Add(MarketCommodity.Create(newCatalog.categories.Last(), "Advanced Catalysers", 3055));
            newCatalog.commodities.Add(MarketCommodity.Create(newCatalog.categories.Last(), "Animal Monitors", 378));
            newCatalog.commodities.Add(MarketCommodity.Create(newCatalog.categories.Last(), "Aquaponic Systems", 349));
            newCatalog.commodities.Add(MarketCommodity.Create(newCatalog.categories.Last(), "Auto Fabricators", 3937));
            newCatalog.commodities.Add(MarketCommodity.Create(newCatalog.categories.Last(), "Bioreducing Lichen", 1089));
            newCatalog.commodities.Add(MarketCommodity.Create(newCatalog.categories.Last(), "Computer Components", 631));
            newCatalog.commodities.Add(MarketCommodity.Create(newCatalog.categories.Last(), "H.E Suits", 349));
            newCatalog.commodities.Add(MarketCommodity.Create(newCatalog.categories.Last(), "Land Enrichment Systems", 5088));
            newCatalog.commodities.Add(MarketCommodity.Create(newCatalog.categories.Last(), "Resonating Separators", 6175));
            newCatalog.commodities.Add(MarketCommodity.Create(newCatalog.categories.Last(), "Robotics", 1976));

            newCatalog.categories.Add(MarketCategory.Create("Textiles"));
            newCatalog.commodities.Add(MarketCommodity.Create(newCatalog.categories.Last(), "Leather", 240));
            newCatalog.commodities.Add(MarketCommodity.Create(newCatalog.categories.Last(), "Natural Fabrics", 493));
            newCatalog.commodities.Add(MarketCommodity.Create(newCatalog.categories.Last(), "Synthetic Fabrics", 252));

            newCatalog.categories.Add(MarketCategory.Create("Waste"));
            newCatalog.commodities.Add(MarketCommodity.Create(newCatalog.categories.Last(), "Biowaste", 74));
            newCatalog.commodities.Add(MarketCommodity.Create(newCatalog.categories.Last(), "Chemical Waste", 79));
            newCatalog.commodities.Add(MarketCommodity.Create(newCatalog.categories.Last(), "Scrap", 96));

            newCatalog.categories.Add(MarketCategory.Create("Weapons"));
            newCatalog.commodities.Add(MarketCommodity.Create(newCatalog.categories.Last(), "Non-Lethal Weapons", 1976));
            newCatalog.commodities.Add(MarketCommodity.Create(newCatalog.categories.Last(), "Personal Weapons", 4474));
            newCatalog.commodities.Add(MarketCommodity.Create(newCatalog.categories.Last(), "Reactive Armour", 2235));

            return newCatalog;
        }

        public IEnumerable<MarketCategory> Categories { get { return this.categories; } }
        public IEnumerable<MarketCommodity> Commodities { get { return this.commodities; } }
    }
}
