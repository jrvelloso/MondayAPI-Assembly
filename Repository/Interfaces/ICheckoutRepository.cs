using Monday.Models;

namespace Monday.Repository.Interfaces
{
    public interface ICheckoutRepository : IGenericRepository<Checkout>
    {
        Task<Checkout> GetByIdIncluded(int id);
    }
}