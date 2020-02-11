using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitingAPI
{
    public class JobService : IJobService
    {
        public List<Job> Jobs { get; set; }

        public JobService()
        {
            Jobs = new List<Job>()
            {
                new Job()
                {
                    Id = 1,
                    Title = "Baker",
                    DegreeRequirements = "Culinary Degree or Comparible Experience",
                    ContactNumber = "555-123-1234",
                    RequiredSkills = "5+ years baking experience. Experience running commercial kitchen. Works well under pressure",
                    Description = "As a baker you will be responsible for making pies and reporting to the head chef.",
                    Salary = "45-50k a year depending on experience",
                    StartDate = "Immediate"
                },
                new Job()
                {
                    Id = 2,
                    Title = "HR Specialist",
                    DegreeRequirements = "Business or Communications Degree",
                    ContactNumber = "555-123-1234",
                    RequiredSkills = "Great communication skills, strong sense of ethics, administrative experience.",
                    Description = "As an HR specialist you will be responsible for developing and enforcing HR policies.",
                    Salary = "40-60k depending on experience",
                    StartDate = "Spring 2020"
                },
                new Job()
                {
                    Id = 3,
                    Title = "Marketing Assistant",
                    Description = "Help develop ad campaigns, raise social media awareness, targeted advertising.",
                    Salary = "Negotiable",
                    StartDate = "Summer 2020",
                    RequiredSkills = "Strong social media and design skills a must.",
                    DegreeRequirements = "Marketing, design or similar.",
                    ContactNumber = "555-123-1234"
                }
            };
        }

        public List<Job> GetAllJobs()
        {
            return Jobs.ToList();
        }

        public Job GetJobById(int id)
        {
            return Jobs.FirstOrDefault(x => x.Id == id);
        }

        public void DeleteJob(int id)
        {
            var jobtoRemove = Jobs.FirstOrDefault(x => x.Id == id);
            Jobs.Remove(jobtoRemove);
        }

        public void CreateJob(Job newJob)
        {
            newJob.Id += (Jobs.OrderBy(x => x.Id).LastOrDefault().Id + 1);
            Jobs.Add(newJob);
        }

        public void UpdateJob(Job newJob)
        {
            var job = Jobs.FirstOrDefault(x => x.Id == newJob.Id);
            job.DegreeRequirements = newJob.DegreeRequirements;
            job.Description = newJob.Description;
            job.Title = newJob.Title;
            job.Salary = newJob.Salary;
            job.StartDate = newJob.StartDate;
            job.RequiredSkills = newJob.RequiredSkills;
        }
    }
}
