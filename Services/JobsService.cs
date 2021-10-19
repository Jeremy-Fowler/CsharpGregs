using System.Collections.Generic;
using CsharpGregs.Data;
using CsharpGregs.Models;

namespace CsharpGregs.Services
{
  public class JobsService
  {
    private readonly FakeDb _db;

    public JobsService(FakeDb db)
    {
      _db = db;
    }

    public List<Job> Get()
    {
      return _db.Jobs;
    }

    public Job Get(int jobId)
    {
      var job = _db.Jobs.Find(j => j.Id == jobId);
      if (job == null)
      {
        throw new System.Exception("No Job With That ID");
      }
      return job;
    }

    public Job CreateJob(Job jobData)
    {
      jobData.Id = _db.GenerateId();
      _db.Jobs.Add(jobData);
      return jobData;
    }

    public Job EditJob(int jobId, Job jobData)
    {
      var job = Get(jobId);
      job.Company = jobData.Company ?? job.Company;
      job.Description = jobData.Description ?? job.Description;
      job.JobTitle = jobData.JobTitle ?? job.JobTitle;
      job.Hours = jobData.Hours;
      job.Rate = jobData.Rate;
      return job;

    }

    public Job DeleteJob(int jobId)
    {
      var job = Get(jobId);
      _db.Jobs.Remove(job);
      return job;
    }
  }
}