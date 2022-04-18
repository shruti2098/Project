using Medical_Management.Model;
using Medical_Management.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medical_Management.Interface
{
    public interface IBilling
    {
        public List<BillingVM> GetBillings();
        public Billing GetBillById(int Billing_Id);
        public Billing AddBill(Billing billing);
        public Billing UpdateBill(Billing billing);
        public void DeleteBill(int Billing_Id);
    }
}
