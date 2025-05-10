//ToDoMonday // Create CRUD methods: POST, PUT, GET AND DELETE

using Monday.Models;
using Monday.Repository.Implementation;
using Monday.Repository.Interfaces;
using Monday.Services.Interface;

namespace Monday.Services.Implementation
{
    public class JobService : IJobService
    {
        private IJobRepository _jobRepository { get; set; }

        public JobService(IJobRepository jobRepository)
        {
            _jobRepository = jobRepository;
        }
        public async Task<List<Job>> GetAll()
        {
            var all = await _jobRepository.GetAllAsync();
            return all.ToList();
        }
    }
}
