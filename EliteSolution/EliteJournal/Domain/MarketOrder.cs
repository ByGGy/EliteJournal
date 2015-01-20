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
        private readonly uint quantity;
        private readonly uint price;

        public MarketOrder(OrderType type, MarketCommodity commodity, uint quantity, uint price)
        {
            this.type = type;
            this.commodityId = commodity.Id;
            this.quantity = quantity;
            this.price = price;
        }

        public OrderType Type { get { return this.type; } }
        public Guid CommodityId { get { return this.commodityId; } }
        public uint Quantity { get { return this.quantity; } }
        public uint Price { get { return this.price; } }
    }
}
