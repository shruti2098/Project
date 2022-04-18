using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Medical_Management.Model
{
    public class MedicineType
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public double UnitPrice { get; set; }
        public string Manufacturer { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        public DateTime ExpiryDate { get; set; }
        public Boolean IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }       
    }
}
