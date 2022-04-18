using Medical_Management.Data;
using Medical_Management.Interface;
using Medical_Management.Model;
using Medical_Management.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medical_Management.Repo
{
    public class CustomerRepo : ICustomer
    {
        ApplicationDbContext _context;
        public CustomerRepo(ApplicationDbContext context)
        {
            _context = context;
        }
        public List<CustomerVM> GetCustomers()
        {
            var result = (from s in _context.Customers
                          select new CustomerVM
                          {
                              CustomerId=s.CustomerId,
                              FullName=s.FullName,
                              CustomerName=s.CustomerName,
                              Password=s.Password,
                              Gender=s.Gender,
                              MobileNo=s.MobileNo,
                              Age=s.Age,
                              Id=s.Id

                          }).ToList();
            return result;
        }
        public Customer GetCustomereById(int Customer_Id)
        {
            return _context.Customers.FirstOrDefault(e => e.CustomerId == Customer_Id);
        }
        public Customer AddCustomer(Customer customer)
        {
            var add=_context.Add(customer);
            _context.SaveChanges();
            return add.Entity;
        }
        public Customer UpdateCustomer(Customer customer)
        {
           var update= _context.Add(customer);
            _context.SaveChanges();
            return update.Entity;
        }
        public void DeleteCustomer(int Id)
        {
            var deletecustomer = _context.Customers.Where(s => s.CustomerId == Id).FirstOrDefault();
            if (deletecustomer != null)
            {
                _context.Remove(deletecustomer);
                _context.SaveChanges();
            }
        }
    }
}
