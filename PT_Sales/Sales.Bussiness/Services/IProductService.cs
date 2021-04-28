using Sales.DataAccess.models;
using System.Collections.Generic;

namespace Sales.Bussiness.Services
{
    public interface IProductService
    {
        Product AddProduct(Product product);
        List<Product> GetProducts();
        Product GetProduct(int id);
        bool UpdateProduct(Product product);
        bool DeleteProduct(int id);
    }
}
