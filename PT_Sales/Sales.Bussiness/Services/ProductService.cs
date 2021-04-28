using Sales.DataAccess.models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.Bussiness.Services
{
    public class ProductService: IProductService
    {
        public SALESContext _salesContext;
        public ProductService (SALESContext salesContext)
        {
            _salesContext = salesContext;
        }

        public Product AddProduct(Product product)
        {
            try
            {
                _salesContext.Add(product);
                _salesContext.SaveChanges();
                return product;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public List<Product> GetProducts()
        {
            try
            {
                return _salesContext.Products.ToList();
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public Product GetProduct(int id)
        {
            try
            {
                return _salesContext.Products.FirstOrDefault(x => x.IdProduct == id);
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public bool UpdateProduct(Product product)
        {
            try
            {
                _salesContext.Products.Update(product);
                _salesContext.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool DeleteProduct(int id)
        {
            try
            {
                var product = _salesContext.Products.FirstOrDefault(x => x.IdProduct == id);
                _salesContext.Products.Remove(product);
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
