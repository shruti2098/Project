using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Medical_Management.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medical_Management.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<MedicineType> MedicineType { get; set; }
        public DbSet<Customer> Customers { get; set; }
        //public DbSet<Stock> Stocks { get; set; }
        public DbSet<Billing> Billings { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
