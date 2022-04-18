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
    [Route("api/[controller]")]
    [ApiController]
    public class BillingController : Controller
    {
        BillingService _repo;
        public BillingController(BillingService repo)
        {
            _repo = repo;
        }
        [HttpGet]
        [Route("GetBills")]
        public IActionResult GetBillings()
        {
            var result = _repo.GetBillings();
            return Ok(result);
        }
        [HttpGet]
        [Route("GetBillById")]
        public IActionResult GetBillById(int Billing_Id)
        {
            var result = _repo.GetBillById(Billing_Id);
            return Ok(result);
        }
        [HttpPost]
        [Route("AddBill")]
        public IActionResult AddBill([FromBody] BillingVM billing)
        {
            try
            {               
                _repo.AddBill(billing);
                return Ok(new Response { Status = "Success", Message = "Bill added Successfully" });
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
        [HttpPut]
        [Route("UpdateCustomer")]
        public IActionResult UpdateBill(Billing billing)
        {
            try
            {
                _repo.UpdateBill(billing);
                return Ok(new Response { Status = "Success", Message = "Bill updated Successfully" });
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
        [HttpDelete]
        [Route("DeleteCustomer")]
        public IActionResult DeleteBill(int Billing_Id)
        {
            try
            {
                _repo.DeleteBill(Billing_Id);
                return Ok(new Response { Status = "Success", Message = "Bill deleted Successfully" });
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}
