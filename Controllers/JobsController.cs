using System.Collections.Generic;
using CsharpGregs.Models;
using CsharpGregs.Services;
using Microsoft.AspNetCore.Mvc;

namespace CsharpGregs.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class JobsController : ControllerBase
  {
    private readonly JobsService _js;

    public JobsController(JobsService js)
    {
      _js = js;
    }

    [HttpGet]
    public ActionResult<List<Job>> GetJobs()
    {
      try
      {
           var jobs = _js.Get();
           return Ok(jobs);
      }
      catch (System.Exception e)
      {
          
          return BadRequest(e.Message);
      }
    }

    [HttpGet("{jobId}")]
    public ActionResult<Job> GetJobById(int jobId)
    {
      try
      {
          var job = _js.Get(jobId);
          return Ok(job);
      }
      catch (System.Exception e)
      {
          
          return BadRequest(e.Message);
      }
    }

    [HttpPost]
    public ActionResult<Job> CreateJob([FromBody] Job jobData)
    {
      try
      {
           var job = _js.CreateJob(jobData);
           return Ok(job);
      }
      catch (System.Exception e)
      {
          
          return BadRequest(e.Message);
      }
    }

    [HttpPut("{jobId}")]
    public ActionResult<Job> EditJob(int jobId, [FromBody] Job jobData)
    {
      try
      {
           var job = _js.EditJob(jobId, jobData);
           return Ok(job);
      }
      catch (System.Exception e)
      {
          
          return BadRequest(e.Message);
      }
    }

    [HttpDelete("{jobId}")]
    public ActionResult<Job> DeleteJob(int jobId)
    {
      try
      {
          var job = _js.DeleteJob(jobId);
          return Ok(job);  
      }
      catch (System.Exception e)
      {
          
          return BadRequest(e.Message);
      }
    }
  }
}