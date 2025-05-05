using Monday.Models;
using Monday.Repository.Interfaces;
using Monday.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monday.Services.Implementation
{
    public class ProductListService : IProductListService
    {
        private IProductListRepository _productListRepository;

        public ProductListService(IProductListRepository productListRepository)
        {
            _productListRepository = productListRepository;
        }

        public async Task<List<CheckoutProduct>> GetAll()
        {
            var all = await _productListRepository.GetAllAsync();
            return all.ToList();
        }
        public async Task<CheckoutProduct> GetById(int id)
        {
            CheckoutProduct productList = await _productListRepository.GetByIdAsync(id);
            return productList;
        }
        public async Task<string> Create(CheckoutProduct productList)
        {
            await _productListRepository.AddAsync(productList);
            return "ProductList created with success";
        }
        public async Task<string> Update(CheckoutProduct productList)
        {
            CheckoutProduct updateProductList = await _productListRepository.GetByIdAsync(productList.Id);
            if (updateProductList != null)
            {
                _productListRepository.Update(productList);
                return "ProductList updated with success";
            }
            else
                return "ProductList not found";
        }
        public async Task<string> Delete(int id)
        {
            CheckoutProduct productList = await _productListRepository.GetByIdAsync(id);
            if (productList == null)
            {
                return "ProductList not founded";
            }
            _productListRepository.Delete(productList);
            return "ProductList removed with success";
        }
    }
}
