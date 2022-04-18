using Medical_Management.Data;
using Medical_Management.Interface;
using Medical_Management.Model;
using Medical_Management.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medical_Management.Repo
{
    //public class StockRepo : IStock
    //{
    //    ApplicationDbContext _context;
    //    public StockRepo(ApplicationDbContext context)
    //    {
    //        _context = context;
    //    }
    //    public List<StockVM> GetStocks()
    //    {
    //        //var result = (from s in _context.Stocks
    //        //              select new StockVM
    //        //              {
    //        //                  Stock_Id=s.Stock_Id,
    //        //                  Name=s.Name,
    //        //                  UnitPrice=s.UnitPrice,
    //        //                  Quantity=s.Quantity,
    //        //                  ExpiryDate=s.ExpiryDate,
    //        //                  Company=s.Company
    //        //              }).ToList();
    //        //return result;
    //    }
    //    //public Stock GetStockById(int Stock_Id)
    //    //{
    //    //    return _context.Stocks.FirstOrDefault(e => e.Stock_Id == Stock_Id);
    //    //}
    //    public void AddStock(Stock stock)
    //    {
    //        _context.Add(stock);
    //        _context.SaveChanges();
    //    }
    //    public void UpdateStock(Stock stock)
    //    {
    //        _context.Add(stock);
    //        _context.SaveChanges();
    //    }
    //    public void DeleteStock(int Id)
    //    {
    //        var deletestock = _context.Stocks.Where(s => s.Stock_Id == Id).FirstOrDefault();
    //        if (deletestock != null)
    //        {
    //            _context.Remove(deletestock);
    //            _context.SaveChanges();
    //        }
    //    }
    //}
}
