using Supermarket.Data.Models;
using Supermarket.Data.ViewModels;
using System.Collections.Generic;

namespace Supermarket.Data.Services
{
    public interface IProductsService
    {
       
   //Defining methods
        Product AddProduct(ProductVM product);
        List<Product> GetAllProducts();
        Product GetProductById(int id);
        Product UpdateProduct(int id, ProductVM newValue);
        void DeleteProduct(int id);
    }
}
