using Medical_Management.Interface;
using Medical_Management.Model;
using Medical_Management.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medical_Management.Services
{
    public class CustomerService 
    {
        ICustomer _service;
        public CustomerService(ICustomer service)
        {
            _service = service;
        }
        public List<CustomerVM> GetCustomers()
        {
            return _service.GetCustomers().ToList();
        }
        public Customer GetCustomereById(int Customer_Id)
        {
            return _service.GetCustomereById(Customer_Id);
        }
        public void AddCustomer(CustomerVM customer)
        {
            Customer customers = new Customer()
            {
                FullName=customer.FullName,
                CustomerName=customer.CustomerName,
                Gender=customer.Gender,
                Password=customer.Password,
                Age=customer.Age,
                MobileNo=customer.MobileNo
            };
            _service.AddCustomer(customers);
        }
        public void UpdateCustomer(Customer customer)
        {
            Customer customers = new Customer()
            {
                FullName = customer.FullName,
                CustomerName = customer.CustomerName,
                Gender = customer.Gender,
                Password = customer.Password,
                Age = customer.Age,
                MobileNo = customer.MobileNo
            };
            _service.UpdateCustomer(customers);
        }
        public void DeleteCustomer(int Customer_Id)
        {
            _service.DeleteCustomer(Customer_Id);
        }
    }
}
