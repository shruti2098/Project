using Medical_Management.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medical_Management.Interface
{
    public interface IMedicalShop
    {
        public List<Medical_Shop> GetSupplier();
        public Medical_Shop GetMedicineByID(int medical);
        public void AddMedical(Medical_Shop medical);
        public void UpdateMedical(Medical_Shop medical);
        public void Delete(int Medical_Shop);
    }
}
