using Medical_Management.Model;
using Medical_Management.Services;
using Medical_Management.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medical_Management.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    //public class StockController : Controller
    //{
    //    StockService _repo;
    //    public StockController(StockService repo)
    //    {
    //        _repo = repo;
    //    }
    //    [HttpGet]
    //    [Route("GetStock")]
    //    public IActionResult GetStocks()
    //    {
    //        var result = _repo.GetStocks();
    //        return Ok(result);
    //    }
    //    [HttpGet]
    //    [Route("GetStockById")]
    //    public IActionResult GetStockById(int Stock_Id)
    //    {
    //        var result = _repo.GetStockById(Stock_Id);
    //        return Ok(result);
    //    }
    //    [HttpPost]
    //    [Route("AddStock")]
    //    public IActionResult AddStock([FromBody] StockVM stock)
    //    {
    //        try
    //        {
    //            if (!ModelState.IsValid)
    //            {
    //                return BadRequest();
    //            }
    //            _repo.AddStock(stock);
    //            return Ok();
    //        }
    //        catch (Exception ex) 
    //        {
    //            return NotFound(ex.Message);
    //        }
    //    }
    //    [HttpPut]
    //    [Route("UpdateStock")]
    //    public IActionResult UpdateStock(Stock stock)
    //    {
    //        try
    //        {
    //            if (!ModelState.IsValid)
    //            {
    //                return BadRequest();
    //            }
    //            _repo.UpdateStock(stock);
    //            return Ok();
    //        }
    //        catch (Exception ex)
    //        {
    //            return NotFound(ex.Message);
    //        }
    //    }
    //    [HttpDelete]
    //    [Route("DeleteStock")]
    //    public IActionResult DeleteStock(int Stock_Id)
    //    {
    //        try
    //        {
    //            _repo.DeleteStock(Stock_Id);
    //            return Ok();
    //        }
    //        catch (Exception ex)
    //        {
    //            return NotFound(ex.Message);
    //        }
    //    }

    //}
}
