using Sales.DataAccess.models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.Bussiness.Services
{
    public class InvoiceService: IInvoiceService
    {
        public SALESContext _salesContext;
        
        public InvoiceService (SALESContext salesContext)
        {
            _salesContext = salesContext;
        }

        public bool AddInvoice(Invoice invoice)
        {
            try
            {
                _salesContext.Add(invoice);
                _salesContext.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public List<Invoice> GetInvoices()
        {
            try
            {
                return _salesContext.Invoices.ToList();
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public Invoice GetInvoiceById(int id)
        {
            try
            {
                return _salesContext.Invoices.FirstOrDefault(x => x.IdInvoice == id);
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public bool DeleteInvoice(int id)
        {
            try
            {
                var invoice = _salesContext.Invoices.FirstOrDefault(x => x.IdInvoice == id);
                if (invoice != null)
                {
                    _salesContext.Remove(invoice);
                    _salesContext.SaveChanges();
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool UpdateInvoice(Invoice invoice)
        {
            try
            {
                _salesContext.Update(invoice);
                _salesContext.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
