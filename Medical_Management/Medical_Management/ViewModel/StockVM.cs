using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medical_Management.ViewModel
{
    public class StockVM
    {
        public int Stock_Id { get; set; }
        public string Name { get; set; }
        public int UnitPrice { get; set; }
        public int Quantity { get; set; }
        public int Company { get; set; }
        public DateTime ExpiryDate { get; set; }
    }
}
