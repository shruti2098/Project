using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medical_Management.ViewModel
{
    public class MedicineTypeVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public double UnitPrice { get; set; }
        public string Manufacturer { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        public DateTime ExpiryDate { get; set; }
    }
}
