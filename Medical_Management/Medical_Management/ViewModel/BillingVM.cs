using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medical_Management.ViewModel
{
    public class BillingVM
    {
        public int BillingId { get; set; }
        public DateTime Date { get; set; }
        public double UnitPrice { get; set; }
        //public int CustomerId { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
    }
}
