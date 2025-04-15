//ToDoMonday // Create CRUD methods: POST, PUT, GET AND DELETE
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
    }
}
