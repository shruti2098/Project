using Medical_Management.Interface;
using Medical_Management.Model;
using Medical_Management.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medical_Management.Services
{
    public class BillingService
    {
        IBilling _service;
        public BillingService(IBilling service)
        {
            _service = service;
        }
        public List<BillingVM> GetBillings()
        {
            return _service.GetBillings().ToList();
        }
        public Billing GetBillById(int Billing_Id)
        {
            return _service.GetBillById(Billing_Id);
        }
        public void AddBill(BillingVM billing)
        {
            Billing bills = new Billing()
            {
                BillingId=billing.BillingId,
                Date=billing.Date,
                Name = billing.Name,
                UnitPrice = billing.UnitPrice,
                Quantity =billing.Quantity
            };
            _service.AddBill(bills);
        }
        public void UpdateBill(Billing billing)
        {
            Billing bills = new Billing()
            {
               BillingId=billing.BillingId,
               Date=billing.Date,              
               Name=billing.Name,
               UnitPrice = billing.UnitPrice,
               Quantity =billing.Quantity
            };
            _service.UpdateBill(bills);
        }
        public void DeleteBill(int Billing_Id)
        {
            _service.DeleteBill(Billing_Id);
        }
    }
}
