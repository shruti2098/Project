using Medical_Management.Model;
using Medical_Management.Services;
using Medical_Management.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medical_Management.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class MedicineController : Controller
    {
        MedicineService _repo;
        public MedicineController(MedicineService repo)
        {
            _repo = repo;
        }
        [HttpGet]
        [Route("GetMedicine")]
        public IActionResult GetMedicineTypes()
        {
            var result = _repo.GetMedicineTypes();
            return Ok(result);
        }
        [HttpGet]
        [Route("GetMedicineById")]
        public IActionResult GetMedicineById(int id)
        {
            var result = _repo.GetMedicineById(id);
            return Ok(result);
        }
        [HttpPost]
        [Route("AddMedicineType")]
        public IActionResult AddMeidicne([FromBody]MedicineTypeVM medicine)
        {
            try
            {
                _repo.AddMedicine(medicine);
                return Ok(new Response { Status = "Success", Message = "Medicine added Successfully" });
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
        [HttpPut]
        [Route("UpdateMedicine")]
        public IActionResult UpdateMedicine(MedicineTypeVM medicineVM)
        {
            try
            {
                _repo.UpdateMedicine(medicineVM);
                return Ok(new Response {Status="Success",Message="Medicine Updated Successfully" });
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
        [HttpDelete]
        [Route("DeleteMedicine/{id}")]
        public IActionResult DeleteMedicine(int id)
        {
            try
            {
                _repo.DeleteMedicine(id);
                return Ok(new Response { Status = "Success", Message = "Medicine deleted Successfully" });
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}
