//ToDoMonday // Create CRUD methods: POST, PUT, GET AND DELETE
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Monday.Models;
using Monday.Repository.Implementation;
using Monday.Repository.Interfaces;
using Monday.Services.Interface;

namespace Monday.Services.Implementation
{
    public class CheckoutService : ICheckoutService
    {
        private ICheckoutRepository _checkoutRepository;
        private ICheckoutProductRepository _checkoutProductRepository;
        private IProductRepository _productRepository;


        public CheckoutService(ICheckoutRepository checkoutRepository, ICheckoutProductRepository checkoutProductRepository, IProductRepository productRepository)
        {
            _checkoutRepository = checkoutRepository;
            _checkoutProductRepository = checkoutProductRepository;
            _checkoutProductRepository = checkoutProductRepository;
        }

        public async Task<IEnumerable<Checkout>> GetAll()
        {
            var all = await _checkoutRepository.GetAllAsync();
            return all.ToList();
        }

        public async Task<Checkout> GetById(int id)
        {
            Checkout checkout = await _checkoutRepository.GetByIdAsync(id);
            return checkout;
        }

        public async Task<string> Create(CheckoutDto checkoutDto)
        {
            
            var checkout = new Checkout();
            checkout.EmployeeId = checkoutDto.EmployeeId;
            checkout.PaymentMethodId = checkoutDto.PaymentMethodId;
            checkout.PurchaseDate = checkoutDto.PurchaseDate;
            await _checkoutRepository.AddAsync(checkout);
            var idCheckout = await _checkoutRepository.SaveAsync();


            var listCheckoutProduct = new List<CheckoutProduct>();

            foreach (var productDto in checkoutDto.ProductList)
            {
                var checkoutProduct = new CheckoutProduct();
                checkoutProduct.ProductId = productDto.Id;
                checkoutProduct.ProductQuantity = productDto.Quantity;
                checkoutProduct.TotalPrice = productDto.TotalPrice;
                listCheckoutProduct.Add(checkoutProduct);
            }

            checkout.TotalPrice = await CalculateTotalPrice(listCheckoutProduct);
            var checkoutSave = await _checkoutRepository.GetByIdAsync(idCheckout);
            await _checkoutRepository.SaveAsync();
            await _checkoutProductRepository.AddListAsync(listCheckoutProduct);
            return "Checkout created with success";
        }
        public async Task<bool> Update(Checkout checkout)
        {
            var existingCheckout = await _checkoutRepository.GetByIdAsync(checkout.Id);

            if (existingCheckout == null)
                return false;

            _checkoutRepository.Update(checkout);
            await _checkoutRepository.SaveAsync();
            return true;
        }

        public async Task<bool> Delete(Checkout checkout)
        {
            var existingCheckout = await _checkoutRepository.GetByIdAsync(checkout.Id);

            if (existingCheckout == null)
                return false;

            _checkoutRepository.Delete(checkout);
            await _checkoutRepository.SaveAsync();
            return true;
        }
        public async Task<decimal> CalculateTotalPrice(List<CheckoutProduct> products)
        {
            return products.Sum(product => product.ProductQuantity * product.TotalPrice);
        }
    }
}
