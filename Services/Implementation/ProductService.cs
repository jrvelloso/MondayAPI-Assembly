//ToDoMonday // Create CRUD methods: POST, PUT, GET AND DELETE
using Monday.Models;
using Monday.Repository.Implementation;
using Monday.Repository.Interfaces;
using Monday.Services.Interface;

namespace Monday.Services.Implementation
{
    public class ProductService : IProductService
    {
        private IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<List<Product>> GetAll()
        {
            var all = await _productRepository.GetAllAsync();
            return all.ToList();
        }
        public async Task<Product> GetById(int id)
        {
            Product product = await _productRepository.GetByIdAsync(id);
            return product;
        }
        public async Task<string> Create(Product product)
        {
            await _productRepository.AddAsync(product);
            return "Product created with success";
        }
        public async Task<string> Update(Product product)
        {
            Product updateProduct = await _productRepository.GetByIdAsync(product.Id);
            if (updateProduct != null)
            {
                _productRepository.Update(product);
                return "Product updated with success";
            }
            else
                return "Product not found";
        }
        public async Task<string> Delete(int id)
        {
            Product product = await _productRepository.GetByIdAsync(id);
            if (product == null)
            {
                return "Product not founded";
            }
            _productRepository.Delete(product);
            return "Product removed with success";
        }
    }
}
