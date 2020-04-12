﻿using System;
using System.Collections.Generic;

namespace BLL.Models
{
    public class PurchaseOrderModel
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public string Name { get; set; }
        public IEnumerable<CommodityModel> Commodities { get; set; }
        public ShopModel Shop { get; set; }
        public WarehouseModel Warehouse { get; set; }
        public DateTime Date { get; set; }
    }
}