using System;

namespace EliteJournal.Domain
{
    public class MarketOrder
    {
        public enum OrderType
        {
            Demand,
            Supply
        }

        private readonly OrderType type;
        private readonly Guid commodityId;
        private readonly uint buyingPrice;
        private readonly uint sellingPrice;

        public MarketOrder(OrderType type, MarketCommodity commodity, uint buyingPrice, uint sellingPrice)
        {
            this.type = type;
            this.commodityId = commodity.Id;
            this.buyingPrice = buyingPrice;
            this.sellingPrice = sellingPrice;
        }

        public OrderType Type { get { return this.type; } }
        public Guid CommodityId { get { return this.commodityId; } }
        public uint BuyingPrice { get { return this.buyingPrice; } }
        public uint SellingPrice { get { return this.sellingPrice; } }
    }
}
