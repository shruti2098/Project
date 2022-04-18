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
    public class MedicineTypeRepo : IMedicineType
    {
        ApplicationDbContext _context;
        public MedicineTypeRepo(ApplicationDbContext context)
        {
            _context = context; 
        }
        public List<MedicineTypeVM> GetMedicineTypes()
        {
            var result = (from s in _context.MedicineType
                          select new MedicineTypeVM
                          {
                              Id = s.Id,
                              Name = s.Name,
                              Type = s.Type,
                              UnitPrice = s.UnitPrice,
                              Manufacturer = s.Manufacturer,
                              Quantity = s.Quantity,
                              Description = s.Description,
                              ExpiryDate = s.ExpiryDate
                          }).ToList();
            return result;
        }
        public MedicineType GetMedicineById(int id)
        {
            return _context.MedicineType.FirstOrDefault(e => e.Id == id);
        }
        public MedicineType AddMedicine(MedicineType medicineType)
        {
            var add=_context.Add(medicineType);
            _context.SaveChanges();
            return add.Entity;
        }
        public MedicineType UpdateMedicine(MedicineType medicineType)
         {
            var update=_context.Update(medicineType);
            _context.SaveChanges();
            return update.Entity;
        }
        public void DeleteMedicine(int id)
        {
            var deletemedicine = _context.MedicineType.Where(s => s.Id == id).FirstOrDefault();
            if (deletemedicine != null)
            {
                _context.Remove(deletemedicine);
                _context.SaveChanges();
            }
        }
    }
}
