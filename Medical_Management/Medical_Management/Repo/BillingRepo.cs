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
    public class BillingRepo : IBilling
    {
        ApplicationDbContext _context;
        public BillingRepo(ApplicationDbContext context)
        {
            _context = context;
        }
        public List<BillingVM> GetBillings()
        {
            var result = (from s in _context.Billings
                          select new BillingVM
                          {
                              BillingId=s.BillingId,
                              Date=s.Date,
                              UnitPrice=s.UnitPrice,
                              Name=s.Name,
                              Quantity=s.Quantity
                          }).ToList();
            return result;
        }
        public Billing GetBillById(int Billing_Id)
        {
            return _context.Billings.FirstOrDefault(e => e.BillingId == Billing_Id);
        }
        public Billing AddBill(Billing billing)
        {
           var add= _context.Add(billing);
            _context.SaveChanges();
            return add.Entity;
        }
        public Billing UpdateBill(Billing billing)
        {
            var update=_context.Add(billing);
            _context.SaveChanges();
            return update.Entity;
        }
        public void DeleteBill(int Billing_Id)
        {
            var deletebill = _context.Billings.Where(s => s.BillingId == Billing_Id).FirstOrDefault();
            if (deletebill != null)
            {
                _context.Remove(deletebill);
                _context.SaveChanges();
            }
        }
    }
}
