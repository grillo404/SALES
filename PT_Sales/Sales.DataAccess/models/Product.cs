using System;
using System.Collections.Generic;

#nullable disable

namespace Sales.DataAccess.models
{
    public partial class Product
    {
        public Product()
        {
            Sales = new HashSet<Sale>();
        }

        public int IdProduct { get; set; }
        public string NameProduct { get; set; }
        public double PriceProduct { get; set; }
        public int StorageProduct { get; set; }
        public DateTime LastModifiet { get; set; }
        public bool ProductActive { get; set; }
        public bool DeleteProduct { get; set; }

        public virtual ICollection<Sale> Sales { get; set; }
    }
}
