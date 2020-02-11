using Microsoft.AspNetCore.Mvc;

namespace RecruitingAPI.Controllers
{
    [Route("[controller]")]
    public class JobsController : Controller
    {
        private readonly IJobService _jobService;

        public JobsController(IJobService jobService)
        {
            _jobService = jobService;
        }

        [HttpGet("/jobs")]
        public IActionResult Get()
        {
            return Ok(_jobService.GetAllJobs());
        }

        [HttpGet("/jobs/{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_jobService.GetJobById(id));
        }

        [HttpPost("/jobs")]
        public IActionResult CreateJob([FromBody]Job newJob)
        {
            _jobService.CreateJob(newJob);
            return Created("job", newJob);
        }

        [HttpPut("/jobs")]
        public IActionResult UpdateJob([FromBody]Job updatedJob)
        {
            _jobService.UpdateJob(updatedJob);
            return Ok(updatedJob);
        }

        [HttpDelete("/jobs/{id}")]
        public IActionResult DeleteJob(int id)
        {
            _jobService.DeleteJob(id);
            return NoContent();
        }
    }
}
