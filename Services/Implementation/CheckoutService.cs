//ToDoMonday // Create CRUD methods: POST, PUT, GET AND DELETE
using Monday.Models;
using Monday.Models.Dtos;
using Monday.Repository.Interfaces;
using Monday.Services.Interface;

namespace Monday.Services.Implementation
{
    public class CheckoutService : ICheckoutService
    {
        private ICheckoutRepository _checkoutRepository;
        private ICheckoutProductRepository _checkoutProductRepository;


        public CheckoutService(ICheckoutRepository checkoutRepository, ICheckoutProductRepository checkoutProductRepository)
        {
            _checkoutRepository = checkoutRepository;
            _checkoutProductRepository = checkoutProductRepository;
        }

        public async Task<string> Create(CheckoutDto checkoutDto)
        {
            // mapping

            var checkout = new Checkout();
            checkout.EmployeeId = checkoutDto.EmployeeId;
            checkout.PaymentMethodId = checkoutDto.PaymentMethodId;
            checkout.CheckoutDate = checkoutDto.CheckoutDate;
            checkout.IsSuccessful = checkoutDto.IsSuccessful;
            await _checkoutRepository.AddAsync(checkout);
            var idCheckout = await _checkoutRepository.SaveAsync();


            var listCheckoutProduct = new List<CheckoutProduct>();

            foreach (var prodId in checkoutDto.ListProductId)
            {
                var checkoutProduct = new CheckoutProduct();
                checkoutProduct.ProductId = prodId;
                checkoutProduct.CheckoutId = idCheckout;
                listCheckoutProduct.Add(checkoutProduct);
            }

            await _checkoutProductRepository.AddListAsync(listCheckoutProduct);
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
        public async Task<decimal> CalculateTotalPrice(List<CheckoutProduct> products)
        {
            return products.Sum(product => product.Product.Price * product.Amount);
        }
    }
}
