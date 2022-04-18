using Medical_Management.Model;
using Medical_Management.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medical_Management.Interface
{
    public interface IMedicineType
    {
        public List<MedicineTypeVM> GetMedicineTypes();
        public MedicineType GetMedicineById(int Id);
        public MedicineType AddMedicine(MedicineType medicine);
        public MedicineType UpdateMedicine(MedicineType medicine);
        public void DeleteMedicine(int medicine);
    }
}
