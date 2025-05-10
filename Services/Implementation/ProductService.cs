//ToDoMonday // Create CRUD methods: POST, PUT, GET AND DELETE
using Microsoft.EntityFrameworkCore;
using Monday.Models;
using Monday.Repository.Interfaces;
using Monday.Services.Interface;

namespace Monday.Services.Implementation
{
    public class ProductService : IProductService
    {
        private IProductRepository _productRepository { get; set; }


        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<List<Product>> GetAll()
        {
            var all = await _productRepository.GetAllAsync();
            return all.ToList();
        }

        public async Task<Product> GetByIdAsync(int id)
        {
            Product product = await _productRepository.GetByIdAsync(id);

            return product;
        }

        public async Task<Product> CreateProduct(Product product)
        {
            await _productRepository.AddAsync(product);
            await _productRepository.SaveAsync();
            return product;
        }
        public async Task<bool> UpdateProduct(Product product)
        {
            var existingProduct = await _productRepository.GetByIdAsync(product.Id);

            if (existingProduct == null)
                return false;

            _productRepository.Update(product);
            await _productRepository.SaveAsync();
            return true;
        }

        public async Task<bool> DeleteProduct(Product product)
        {
            var existingProduct = await _productRepository.GetByIdAsync(product.Id);

            if (existingProduct == null)
                return false;

            _productRepository.Delete(product);
            await _productRepository.SaveAsync();
            return true;
        }
    }
}
