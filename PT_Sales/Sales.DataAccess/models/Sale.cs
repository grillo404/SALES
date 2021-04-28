using System;
using System.Collections.Generic;

#nullable disable

namespace Sales.DataAccess.models
{
    public partial class Sale
    {
        public int IdSale { get; set; }
        public int FkIdProduct { get; set; }
        public int FkIdClient { get; set; }
        public int FkIdInvoice { get; set; }

        public virtual Client FkIdClientNavigation { get; set; }
        public virtual Invoice FkIdInvoiceNavigation { get; set; }
        public virtual Product FkIdProductNavigation { get; set; }
    }
}
