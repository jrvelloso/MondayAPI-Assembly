//ToDoMonday // Create CRUD methods: POST, PUT, GET AND DELETE
using Monday.Models;
using Monday.Repository.Implementation;
using Monday.Repository.Interfaces;
using Monday.Services.Interface;

namespace Monday.Services.Implementation
{
    public class CheckoutService : ICheckoutService
    {
        private ICheckoutRepository _checkoutRepository;

        public CheckoutService(ICheckoutRepository checkoutRepository)
        {
            _checkoutRepository = checkoutRepository;
        }

        public async Task<string> Create(Checkout checkout)
        {
            await _checkoutRepository.AddAsync(checkout);
            await _checkoutRepository.SaveAsync();
            return "Checkout created with success";
        }

        public async Task<Checkout?> GetById(int id)
        {
            return await _checkoutRepository.GetByIdAsync(id);
        }
        public async Task<Checkout?> GetByIdIncluded(int id)
        {
            Checkout checkout = await _checkoutRepository.GetByIdIncluded(id);
            if (checkout == null)
            {
                throw new KeyNotFoundException($"Checkout not found.");
            }
            return checkout;
        }

        public async Task<IEnumerable<Checkout>> GetAll()
        {
            return await _checkoutRepository.GetAllAsync();
        }

        public async Task<string> Update(Checkout checkout)
        {
            _checkoutRepository.Update(checkout);
            await _checkoutRepository.SaveAsync();
            return "Checkout updated with success";   
        }

        public async Task<string> Delete(int id)
        {
            var checkout = await GetById(id);
            if (checkout != null)
            {
                _checkoutRepository.Delete(checkout);
                await _checkoutRepository.SaveAsync();
                return "Checkout deleted with success";
            }
            else
            {
                return "Error to delete checkout";
            }
        }
        public async Task<List<ProductList>> CreateProductList(List<ProductList> products)
        {
            var productList = new List<ProductList>();

            foreach (var product in products)
            {
                productList.Add(product);
            }

            return productList;
        }
        public async Task<decimal> CalculateTotalPrice(List<ProductList> products)
        {
            return products.Sum(product => product.Product.Price * product.Amount);
        }
    }
}
