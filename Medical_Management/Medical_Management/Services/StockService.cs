using Medical_Management.Interface;
using Medical_Management.Model;
using Medical_Management.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medical_Management.Services
{
    //public class StockService
    //{
    //    IStock _service;
    //    public StockService(IStock service)
    //    {
    //        _service = service;
    //    }
    //    public List<StockVM> GetStocks()
    //    {
    //        return _service.GetStocks().ToList();
    //    }
    //    public Stock GetStockById(int Stock_Id)
    //    {
    //        return _service.GetStockById(Stock_Id);
    //    }
    //    public void AddStock(StockVM stock)
    //    {
    //        Stock stock1 = new Stock()
    //        {
    //            Name=stock.Name,
    //            UnitPrice=stock.UnitPrice,
    //            Quantity=stock.Quantity,
    //            Company=stock.Company,
    //            ExpiryDate=stock.ExpiryDate
               
    //        };
    //        _service.AddStock(stock1);
    //    }
    //    public void UpdateStock(Stock stock)
    //    {
    //        Stock stock1 = new Stock()
    //        {
    //            Name = stock.Name,
    //            UnitPrice = stock.UnitPrice,
    //            Quantity = stock.Quantity,
    //            Company = stock.Company,
    //            ExpiryDate = stock.ExpiryDate
              

    //        };
    //        _service.UpdateStock(stock1);
    //    }
    //    public void DeleteStock(int Id)
    //    {
    //        _service.DeleteStock(Id);
    //    }
    //}
}
