using Medical_Management.Interface;
using Medical_Management.Model;
using Medical_Management.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medical_Management.Services
{
    public class MedicineService
    {
        IMedicineType _service;
        public MedicineService(IMedicineType service)
        {
            _service = service;
        }
        public List<MedicineTypeVM> GetMedicineTypes()
        {
            return _service.GetMedicineTypes().ToList();
        }
        public MedicineType GetMedicineById(int Id)
        {
            return _service.GetMedicineById(Id);
        }
        public void AddMedicine(MedicineTypeVM medicine)
        {
            MedicineType medicinetype = new MedicineType()
            {
                Id=medicine.Id,
                Name = medicine.Name,
                Type = medicine.Type,
                UnitPrice = medicine.UnitPrice,
                Manufacturer = medicine.Manufacturer,
                Quantity = medicine.Quantity,
                Description = medicine.Description,
                ExpiryDate = medicine.ExpiryDate 
            };
            _service.AddMedicine(medicinetype);
        }
        public void UpdateMedicine(MedicineTypeVM medicineVM)
        {
            MedicineType medicinetype = new MedicineType()
            {
                Id=medicineVM.Id,
                Name = medicineVM.Name,
                Type = medicineVM.Type,
                UnitPrice = medicineVM.UnitPrice,
                Manufacturer = medicineVM.Manufacturer,
                Quantity = medicineVM.Quantity,
                Description = medicineVM.Description,
                ExpiryDate = medicineVM.ExpiryDate
            };
            _service.UpdateMedicine(medicinetype);
        }
        public void DeleteMedicine(int Id)
        {
            _service.DeleteMedicine(Id);
        }
    }
}
