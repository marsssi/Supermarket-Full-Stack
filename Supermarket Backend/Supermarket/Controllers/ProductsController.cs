using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Supermarket.Data.Services;
using Supermarket.Data.ViewModels;

namespace Supermarket.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowAll")]


    public class ProductsController : ControllerBase
    {

        //Inject ProductsServices file
        private IProductsService _productsService;


        //The Constructor
        public ProductsController(IProductsService productsService)
        {
            _productsService = productsService;
        }



        //Creating #1 API endpoint (HttpPost) to add products 
        [HttpPost("add-product")]
        public IActionResult AddProduct([FromBody] ProductVM product)
        {
            _productsService.AddProduct(product);
            return Ok();
        }



        //Creating #2 API endpoint (HttpGet) to list all products
        [HttpGet("get-all-products")]
        public IActionResult GetAllProducts()
        {
            var result = _productsService.GetAllProducts();
            return Ok(result);
        }


        //Creating #3 API endpoint (HttpGet) to list a product by Id
        [HttpGet("get-product-by-Id/{id}")]
        public IActionResult GetProductById(int id)
        {
            var result = _productsService.GetProductById(id);
            return Ok(result);
        }




        //Creating #4 API endpoint (HttpPut) to update an existing product by Id
        [HttpPut("update-product-by-Id/{id}")]
        public IActionResult UpdateProduct(int id, [FromBody] ProductVM product)
        {
            var dbProduct = _productsService.GetProductById(id);
            return Ok(dbProduct);
        }



        //Creating #5 API endpoint (HttpDelete) to delete a product by Id
        [HttpDelete("delete-product-by-Id/{id}")]
        public IActionResult DeleteProduct(int id)
        {
            _productsService.DeleteProduct(id);
            return Ok();
        }
    }
}
