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
    public class CustomerController : Controller
    {
        CustomerService _repo;
        public CustomerController(CustomerService repo)
        {
            _repo = repo;
        }
        [HttpGet]
        [Route("GetCustomer")]
        public IActionResult GetCustomers()
        {
            var result = _repo.GetCustomers();
            return Ok(result);
        }
        [HttpGet]
        [Route("GetCustomereById")]
        public IActionResult GetCustomereById(int Customer_Id)
        {
            var result = _repo.GetCustomereById(Customer_Id);
            return Ok(result);
        }
        [HttpPost]
        [Route("AddCustomer")]
        public IActionResult AddCustomer([FromBody] CustomerVM customer)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }
                _repo.AddCustomer(customer);
                return Ok();
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
        [HttpPut]
        [Route("UpdateCustomer")]
        public IActionResult UpdateCustomer(Customer customer)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }
                _repo.UpdateCustomer(customer);
                return Ok();
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
        [HttpDelete]
        [Route("DeleteCustomer")]
        public IActionResult DeleteCustomer(int Id)
        {
            try
            {
                _repo.DeleteCustomer(Id);
                return Ok();
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}
