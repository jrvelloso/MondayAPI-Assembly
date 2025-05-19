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

        public async Task<Job> GetById(int id)
        {
            Job job = await _jobRepository.GetByIdAsync(id);

            return job;
        }

        public async Task<Job>  Create(Job job)
        {
            await _jobRepository.AddAsync(job);
            await _jobRepository.SaveAsync();
            return job;
        }
        public async Task<bool> Update(Job job)
        {
            var existingJob = await _jobRepository.GetByIdAsync(job.Id);

            if (existingJob == null)
                return false;

            _jobRepository.Update(job);
            await _jobRepository.SaveAsync();
            return true;
        }

        public async Task<bool> Delete(Job job)
        {
            var existingJob = await _jobRepository.GetByIdAsync(job.Id);

            if (existingJob == null)
                return false;

            _jobRepository.Delete(job);
            await _jobRepository.SaveAsync();
            return true;
        }
    }
}
