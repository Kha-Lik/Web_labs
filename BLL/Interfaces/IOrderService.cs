using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BLL.Models;

namespace BLL.Interfaces
{
    public interface IOrderService
    {
        IEnumerable<PurchaseOrderModel> GetAll();
        PurchaseOrderModel Search(string name);
        IEnumerable<PurchaseOrderModel> Search(DateTime date);
        IEnumerable<PurchaseOrderModel> Search(int quantity);
        Task MakeOrder(IEnumerable<CommodityModel> commodities, ShopModel shop, string name, int number);
        Task MakeOrder(IEnumerable<CommodityModel> commodities, WarehouseModel warehouse, string name, int number);
    }
}