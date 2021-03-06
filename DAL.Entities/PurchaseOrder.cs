using System;
using System.Collections.Generic;

namespace DAL.Entities
{
    public class PurchaseOrder : BaseEntity
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public IEnumerable<OrdersCommodities> Commodities { get; set; }
        public int? ShopId { get; set; }
        public int? WarehouseId { get; set; }
        public Shop Shop { get; set; }
        public Warehouse Warehouse { get; set; }
        public DateTime Date { get; set; }
    }
}