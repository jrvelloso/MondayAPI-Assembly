using Microsoft.AspNetCore.Mvc;
using Monday.Models;
using Monday.Services.Implementation;
using Monday.Services.Interface;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CheckoutController : ControllerBase
    {
        private readonly ICheckoutService _checkoutService;
        private readonly IProductListService _productListService;

        public CheckoutController(ICheckoutService checkoutService, IProductListService productListService)
        {
            _checkoutService = checkoutService;
            _productListService = productListService;
        }
        public async Task<string> Create(Checkout checkout)
        {
            string msg = await _checkoutService.Create(checkout);
            return msg;
        }

        [HttpGet]
        public async Task<Checkout> GetById(int id)
        {
            var checkout = await _checkoutService.GetById(id);

            return checkout;
        }
        [HttpGet("GetByIdIncluded")]
        public async Task<Checkout> GetByIdIncluded(int id)
        {
            var checkout = await _checkoutService.GetByIdIncluded(id);
            return checkout;
        }

        [HttpGet("GetAll")]
        public async Task<IEnumerable<Checkout>> GetAll()
        {
            var checkouts = await _checkoutService.GetAll();
            return checkouts;
        }

        [HttpPut]
        public async Task<string> Update(Checkout checkout)
        {
            string msg = await _checkoutService.Update(checkout);
            return msg;
        }
        [HttpDelete]
        public async Task<string> Delete(int id)
        {
            string msg = await _checkoutService.Delete(id);
            return msg;
        }
        //public async Task<List<ProductList>> CreateProductList() 
        //{
        //    List<ProductList> AllproductList = new List<ProductList>();
        //    do
        //    {
        //        string msg = await _productListService.Create(ProductList);
        //    } while (true);

        //        return _checkoutService.CreateProductList();
        //}
        public async Task<decimal> CalculateTotalPrice(List<ProductList> productsList)
        {
            decimal total = await _checkoutService.CalculateTotalPrice(productsList);
            return total;
        }
    }
}
