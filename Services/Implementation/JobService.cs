//ToDoMonday // Create CRUD methods: POST, PUT, GET AND DELETE

using Monday.Models;
using Monday.Repository.Implementation;
using Monday.Repository.Interfaces;
using Monday.Services.Interface;
using System.Net;

namespace Monday.Services.Implementation
{
    public class JobService : IJobService
    {
        private IJobRepository _jobRepository { get; set; }

        public JobService(IJobRepository jobRepository)
        {
            _jobRepository = jobRepository;
        }

        public async Task<string> Create(Job job)
        {
            await _jobRepository.AddAsync(job);
            return "Job created with success";
        }

        public async Task<string> Delete(int id)
        {
            Job job = await _jobRepository.GetByIdAsync(id);
            if (job == null)
            {
                return "Job not founded";
            }
            _jobRepository.Delete(job);
            return "Job removed with success";
        }

        public async Task<List<Job>> GetAll()
        {
            var jobs = await _jobRepository.GetAllAsync();
            return jobs.ToList();
        }

        public async Task<Job> GetById(int id)
        {
            Job job = await _jobRepository.GetByIdAsync(id);
            return job;
        }

        public async Task<string> Update(Job job)
        {
            Job jobUpdate = await _jobRepository.GetByIdAsync(job.Id);
            if (jobUpdate == null)
            {
                return "Job not founded";
            }
            _jobRepository.Update(jobUpdate);
            return "Job updated with sucess";
        }
    }
}
