using Medical_Management.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medical_Management.ViewModel
{
    public class CustomerVM
    {
        public int CustomerId { get; set; }
        public string FullName { get; set; }
        public string CustomerName { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
        public string MobileNo { get; set; }
        public int Age { get; set; }
        public int Id { get; set; }
        public virtual MedicineType MedicineType { get; set; }
    }
}
