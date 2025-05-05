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
        public async Task<string> Create(Job job)
        {
            string msg = await _jobService.Create(job);
            return msg;
        }

        [HttpGet]
        public async Task<Job> GetById(int id)
        {
            var job = await _jobService.GetById(id);

            return job;
        }

        [HttpGet("GetAll")]
        public async Task<IEnumerable<Job>> GetAll()
        {
            var jobs = await _jobService.GetAll();
            return jobs;
        }

        [HttpPut]
        public async Task<string> Update(Job job)
        {
            string msg = await _jobService.Update(job);
            return msg;
        }
        [HttpDelete]
        public async Task<string> Delete(int id)
        {
            string msg = await _jobService.Delete(id);
            return msg;
        }
    }
}
