using Medical_Management.Model;
using Medical_Management.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medical_Management.Interface
{
    public interface ICustomer
    {
        public List<CustomerVM> GetCustomers();
        public Customer GetCustomereById(int Customer_Id);
        public Customer AddCustomer(Customer customer);
        public Customer UpdateCustomer(Customer customer);
        public void DeleteCustomer(int customer);
    }
}
