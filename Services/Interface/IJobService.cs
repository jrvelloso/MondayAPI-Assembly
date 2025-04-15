//ToDoMonday 

using Monday.Models;

namespace Monday.Services.Interface
{
    public interface IJobService
    {
        Task<string> Create(Job job);
        Task<string> Delete(int id);
        Task<List<Job>> GetAll();
        Task<Job> GetById(int id);
        Task<string> Update(Job job);
    }
}