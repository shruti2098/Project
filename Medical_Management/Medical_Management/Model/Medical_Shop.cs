using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Medical_Management.Model
{
    public class Medical_Shop
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public decimal Mobile_number { get; set; }
        public DateTime Medical_IN { get; set; }
        public DateTime Medical_OUT { get; set; }

    }
}
