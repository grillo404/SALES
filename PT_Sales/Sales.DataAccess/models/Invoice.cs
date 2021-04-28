using System;
using System.Collections.Generic;

#nullable disable

namespace Sales.DataAccess.models
{
    public partial class Invoice
    {
        public Invoice()
        {
            Sales = new HashSet<Sale>();
        }

        public int IdInvoice { get; set; }
        public DateTime SaleDate { get; set; }
        public string Comments { get; set; }
        public DateTime LastModifiet { get; set; }
        public bool DeleteInvoice { get; set; }

        public virtual ICollection<Sale> Sales { get; set; }
    }
}
