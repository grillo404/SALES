using System.Collections.Generic;
using Sales.DataAccess.models;

namespace Sales.Bussiness.Services
{
    public interface IInvoiceService
    {
        bool AddInvoice(Invoice invoice);
        List<Invoice> GetInvoices();
        Invoice GetInvoiceById(int id);
        bool DeleteInvoice(int id);
        bool UpdateInvoice(Invoice invoice);
    }
}
