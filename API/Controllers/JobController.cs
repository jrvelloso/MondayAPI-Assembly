using Microsoft.AspNetCore.Mvc;
using Monday.Models;
using Monday.Services.Interface;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JobController : ControllerBase
    {
        private readonly IJobService _jobService;

        public JobController(IJobService jobService)
        {
            _jobService = jobService;
        }

        [HttpGet]
        public async Task<Job> GetById(int id)
        {
            var job = await _jobService.GetById(id);

            return job;
        }

        [HttpGet]
        public async Task<List<Job>> GetAll()
        {
            var jobs = await _jobService.GetAll();
            return jobs.ToList();
        }

        [HttpGet]
        public async Task<string> Create(Job job)
        {
            string message = "";
            await _jobService.Create(job);

            return message;
        }

        [HttpGet]
        public async Task<bool> Update(Job job)
        {
            var existingJob = await _jobService.Update(job);
            return true;
        }

        [HttpGet]
        public async Task<bool> Delete(Job job)
        {
            var existingJob = await _jobService.Delete(job);
            return true;
        }
    }
}
