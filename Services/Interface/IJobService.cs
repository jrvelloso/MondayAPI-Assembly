//ToDoMonday 

using Monday.Models;

namespace Monday.Services.Interface
{
    public interface IJobService
    {
        Task<List<Job>> GetAll();
        Task<Job> GetById(int id);
        Task<Job> Add(Job job);
        Task<bool> Update(Job job);
        Task<bool> Delete(Job job);
    }
}