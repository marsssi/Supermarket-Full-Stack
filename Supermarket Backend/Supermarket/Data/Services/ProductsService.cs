using Supermarket.Data.Models;
using Supermarket.Data.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace Supermarket.Data.Services
{
    public class ProductsService:IProductsService
    {
        //Inject AppDbContext file
        private AppDbContext _context;


        //The Constructor
        public ProductsService(AppDbContext context)
        {
            _context = context;
        }



 // ------------------  CREATING  METHODS --------------------------------------------------------------------------------

        //Creating a method to add products
        public Product AddProduct(ProductVM product)
        {
            var _product = new Product()
            {
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                ExpDate = product.ExpDate,
                DateCreated = System.DateTime.Now,
                SectorId = product.SectorId,
            };

            _context.Products.Add(_product);
            _context.SaveChanges();

            return _product;
        }



        //Creating a method to list all products
        public List<Product> GetAllProducts() => _context.Products.ToList();



        //Creating a method to list a product by ID
        public Product GetProductById(int id) => _context.Products.FirstOrDefault(n => n.Id == id);



        //Creating a method to update a product by ID
        public Product UpdateProduct(int id, ProductVM newValue)
        {
            var dbProduct = _context.Products.FirstOrDefault(x => x.Id == id);
            if (dbProduct != null)
            {
                dbProduct.Name = newValue.Name;
                dbProduct.Description = newValue.Description;
                dbProduct.Price = newValue.Price;
                dbProduct.ExpDate = newValue.ExpDate;
                dbProduct.SectorId = newValue.SectorId;

                _context.SaveChanges();
            }
            return dbProduct;
        }



        //Creating a method to delete a product by ID
        public void DeleteProduct(int id)
        {
            var dbProduct = _context.Products.FirstOrDefault(x => x.Id == id);
            if (dbProduct != null)
            {
                _context.Products.Remove(dbProduct);
                _context.SaveChanges();
            }
        }
    }
}


