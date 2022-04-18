using Medical_Management.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medical_Management.Data
{
    public class MedicalDataBaseContext : DbContext
    {
        public MedicalDataBaseContext(DbContextOptions<MedicalDataBaseContext> options) : base(options)
        {
        }
        public DbSet<MedicineType> MedicineType { get; set; }
        public DbSet<Customer> Customers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
