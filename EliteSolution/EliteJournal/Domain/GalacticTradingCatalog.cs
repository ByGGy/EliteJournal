using System;
using System.Collections.Generic;
using System.Linq;

namespace EliteJournal.Domain
{
    public class GalacticTradingCatalog
    {
        private Guid id;

        private List<MarketCategory> categories;
        private List<MarketGood> goods;

        private GalacticTradingCatalog()
        {
            this.id = Guid.Empty;

            this.categories = new List<MarketCategory>();
            this.goods = new List<MarketGood>();
        }

        //Based on ingame data from version 1.05 (17/01/15)
        //Legal Goods Only
        //Ordered from the Commodity Market panel (looks like alpha order, which is different than the Navigation Map)
        public static GalacticTradingCatalog CreateDefault()
        {
            GalacticTradingCatalog newCatalog = new GalacticTradingCatalog();

            newCatalog.id = Guid.NewGuid();

            newCatalog.categories.Add(MarketCategory.Create("Chemicals"));
            newCatalog.goods.Add(MarketGood.Create(newCatalog.categories.Last(), "Explosives", 0));   //Need Price
            newCatalog.goods.Add(MarketGood.Create(newCatalog.categories.Last(), "Hydrogen Fuel", 147));
            newCatalog.goods.Add(MarketGood.Create(newCatalog.categories.Last(), "Mineral Oil", 259));
            newCatalog.goods.Add(MarketGood.Create(newCatalog.categories.Last(), "Pesticides", 292));

            newCatalog.categories.Add(MarketCategory.Create("Consumer Items"));
            newCatalog.goods.Add(MarketGood.Create(newCatalog.categories.Last(), "Clothing", 395));
            newCatalog.goods.Add(MarketGood.Create(newCatalog.categories.Last(), "Consumer Technology", 7031));
            newCatalog.goods.Add(MarketGood.Create(newCatalog.categories.Last(), "Domestic Appliances", 631));

            newCatalog.categories.Add(MarketCategory.Create("Engineered Ceramics"));
            newCatalog.goods.Add(MarketGood.Create(newCatalog.categories.Last(), "Polymers", 0));   //Need Price
            newCatalog.goods.Add(MarketGood.Create(newCatalog.categories.Last(), "SemiConductors", 0));   //Need Price
            newCatalog.goods.Add(MarketGood.Create(newCatalog.categories.Last(), "SuperConductors", 0));   //Need Price

            newCatalog.categories.Add(MarketCategory.Create("Foods"));
            newCatalog.goods.Add(MarketGood.Create(newCatalog.categories.Last(), "Algae", 200));
            newCatalog.goods.Add(MarketGood.Create(newCatalog.categories.Last(), "Animal Meat", 1460));
            newCatalog.goods.Add(MarketGood.Create(newCatalog.categories.Last(), "Coffee", 1460));
            newCatalog.goods.Add(MarketGood.Create(newCatalog.categories.Last(), "Fish", 493));
            newCatalog.goods.Add(MarketGood.Create(newCatalog.categories.Last(), "Food Cartridges", 0));   //Need Price
            newCatalog.goods.Add(MarketGood.Create(newCatalog.categories.Last(), "Fruit And Vegetables", 395));
            newCatalog.goods.Add(MarketGood.Create(newCatalog.categories.Last(), "Grain", 275));
            newCatalog.goods.Add(MarketGood.Create(newCatalog.categories.Last(), "Synthetic Meat", 0));   //Need Price
            newCatalog.goods.Add(MarketGood.Create(newCatalog.categories.Last(), "Tea", 1646));

            newCatalog.categories.Add(MarketCategory.Create("Legal Drugs"));
            newCatalog.goods.Add(MarketGood.Create(newCatalog.categories.Last(), "Beer", 240));
            newCatalog.goods.Add(MarketGood.Create(newCatalog.categories.Last(), "Liquor", 738));
            newCatalog.goods.Add(MarketGood.Create(newCatalog.categories.Last(), "Tobacco", 5088));
            newCatalog.goods.Add(MarketGood.Create(newCatalog.categories.Last(), "Wine", 324));

            newCatalog.categories.Add(MarketCategory.Create("Machinery"));
            newCatalog.goods.Add(MarketGood.Create(newCatalog.categories.Last(), "Atmospheric Processors", 493));
            newCatalog.goods.Add(MarketGood.Create(newCatalog.categories.Last(), "Crop Harvesters", 2378));
            newCatalog.goods.Add(MarketGood.Create(newCatalog.categories.Last(), "Marine Equipment", 4474));
            newCatalog.goods.Add(MarketGood.Create(newCatalog.categories.Last(), "Microbial Furnaces", 0));   //Need Price
            newCatalog.goods.Add(MarketGood.Create(newCatalog.categories.Last(), "Mineral Extractors", 0));   //Need Price
            newCatalog.goods.Add(MarketGood.Create(newCatalog.categories.Last(), "Power Generators", 631));
            newCatalog.goods.Add(MarketGood.Create(newCatalog.categories.Last(), "Water Purifiers", 378));

            newCatalog.categories.Add(MarketCategory.Create("Medicines"));
            newCatalog.goods.Add(MarketGood.Create(newCatalog.categories.Last(), "Agri-Medicines", 1154));
            newCatalog.goods.Add(MarketGood.Create(newCatalog.categories.Last(), "Basic Medicines", 395));
            newCatalog.goods.Add(MarketGood.Create(newCatalog.categories.Last(), "Combat Stabilisers", 0));   //Need Price
            newCatalog.goods.Add(MarketGood.Create(newCatalog.categories.Last(), "Performance Enhancers", 7031));
            newCatalog.goods.Add(MarketGood.Create(newCatalog.categories.Last(), "Progenitor Cells", 7031));

            newCatalog.categories.Add(MarketCategory.Create("Metals"));
            newCatalog.goods.Add(MarketGood.Create(newCatalog.categories.Last(), "Aluminium", 0));   //Need Price
            newCatalog.goods.Add(MarketGood.Create(newCatalog.categories.Last(), "Beryllium", 0));   //Need Price
            newCatalog.goods.Add(MarketGood.Create(newCatalog.categories.Last(), "Cobalt", 0));   //Need Price
            newCatalog.goods.Add(MarketGood.Create(newCatalog.categories.Last(), "Copper", 0));   //Need Price
            newCatalog.goods.Add(MarketGood.Create(newCatalog.categories.Last(), "Indium", 0));   //Need Price
            newCatalog.goods.Add(MarketGood.Create(newCatalog.categories.Last(), "Gallium", 0));   //Need Price
            newCatalog.goods.Add(MarketGood.Create(newCatalog.categories.Last(), "Gold", 0));   //Need Price
            newCatalog.goods.Add(MarketGood.Create(newCatalog.categories.Last(), "Lithium", 0));   //Need Price
            newCatalog.goods.Add(MarketGood.Create(newCatalog.categories.Last(), "Palladium", 0));   //Need Price
            newCatalog.goods.Add(MarketGood.Create(newCatalog.categories.Last(), "Platinum", 0));   //Need Price
            newCatalog.goods.Add(MarketGood.Create(newCatalog.categories.Last(), "Silver", 0));   //Need Price
            newCatalog.goods.Add(MarketGood.Create(newCatalog.categories.Last(), "Tantalum", 0));   //Need Price
            newCatalog.goods.Add(MarketGood.Create(newCatalog.categories.Last(), "Titanium", 0));   //Need Price
            newCatalog.goods.Add(MarketGood.Create(newCatalog.categories.Last(), "Uranium", 0));   //Need Price

            newCatalog.categories.Add(MarketCategory.Create("Minerals"));
            newCatalog.goods.Add(MarketGood.Create(newCatalog.categories.Last(), "Bauxite", 0));   //Need Price
            newCatalog.goods.Add(MarketGood.Create(newCatalog.categories.Last(), "Bertrandite", 0));   //Need Price
            newCatalog.goods.Add(MarketGood.Create(newCatalog.categories.Last(), "Coltan", 0));   //Need Price
            newCatalog.goods.Add(MarketGood.Create(newCatalog.categories.Last(), "Gallite", 0));   //Need Price
            newCatalog.goods.Add(MarketGood.Create(newCatalog.categories.Last(), "Indite", 0));   //Need Price
            newCatalog.goods.Add(MarketGood.Create(newCatalog.categories.Last(), "Lepidolite", 0));   //Need Price
            newCatalog.goods.Add(MarketGood.Create(newCatalog.categories.Last(), "Rutile", 0));   //Need Price
            newCatalog.goods.Add(MarketGood.Create(newCatalog.categories.Last(), "Uraninite", 0));   //Need Price

            newCatalog.categories.Add(MarketCategory.Create("Technology"));
            newCatalog.goods.Add(MarketGood.Create(newCatalog.categories.Last(), "Advanced Catalysers", 0));   //Need Price
            newCatalog.goods.Add(MarketGood.Create(newCatalog.categories.Last(), "Animal Monitors", 378));
            newCatalog.goods.Add(MarketGood.Create(newCatalog.categories.Last(), "Aquaponic Systems", 349));
            newCatalog.goods.Add(MarketGood.Create(newCatalog.categories.Last(), "Auto Fabricators", 0));   //Need Price
            newCatalog.goods.Add(MarketGood.Create(newCatalog.categories.Last(), "Bioreducing Lichen", 0));   //Need Price
            newCatalog.goods.Add(MarketGood.Create(newCatalog.categories.Last(), "Computer Components", 0));   //Need Price
            newCatalog.goods.Add(MarketGood.Create(newCatalog.categories.Last(), "H.E Suits", 0));   //Need Price
            newCatalog.goods.Add(MarketGood.Create(newCatalog.categories.Last(), "Land Enrichment Systems", 5088));
            newCatalog.goods.Add(MarketGood.Create(newCatalog.categories.Last(), "Resonating Separators", 0));   //Need Price
            newCatalog.goods.Add(MarketGood.Create(newCatalog.categories.Last(), "Robotics", 0));   //Need Price

            newCatalog.categories.Add(MarketCategory.Create("Textiles"));
            newCatalog.goods.Add(MarketGood.Create(newCatalog.categories.Last(), "Leather", 240));
            newCatalog.goods.Add(MarketGood.Create(newCatalog.categories.Last(), "Natural Fabrics", 493));
            newCatalog.goods.Add(MarketGood.Create(newCatalog.categories.Last(), "Synthetic Fabrics", 0));   //Need Price

            newCatalog.categories.Add(MarketCategory.Create("Waste"));
            newCatalog.goods.Add(MarketGood.Create(newCatalog.categories.Last(), "Biowaste", 74));
            newCatalog.goods.Add(MarketGood.Create(newCatalog.categories.Last(), "Scrap", 0));   //Need Price

            newCatalog.categories.Add(MarketCategory.Create("Weapons"));
            newCatalog.goods.Add(MarketGood.Create(newCatalog.categories.Last(), "Personal Weapons", 0));   //Need Price
            newCatalog.goods.Add(MarketGood.Create(newCatalog.categories.Last(), "Battle Weapons", 0));   //Need Price
            newCatalog.goods.Add(MarketGood.Create(newCatalog.categories.Last(), "Reactive Armour", 0));   //Need Price
            newCatalog.goods.Add(MarketGood.Create(newCatalog.categories.Last(), "Non-Lethal Weapons", 0));   //Need Price

            return newCatalog;
        }
    }
}
