using System.Collections.Generic;

namespace RecruitingAPI
{
    public interface IJobService
    {
        void CreateJob(Job newJob);
        void UpdateJob(Job updatedJob);
        void DeleteJob(int id);
        List<Job> GetAllJobs();
        Job GetJobById(int id);
    }
}