//ToDoMonday // Create CRUD methods: POST, PUT, GET AND DELETE

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
    }
}
