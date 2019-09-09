using System;
using System.Collections.Generic;

namespace JobWebsite.Models.Job
{
    public class Job : Base
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Responsibilities{get;set;}
        public TimeSpan WorkingHoursStart{get;set;}
        public TimeSpan WorkingHoursEnd{get;set;}
        public int MinSalary { get; set; }
        public int MaxSalary { get; set; }
        public DateTime PublishDate { get; set; }
        public DateTime ClosingDate { get; set; }
        public bool IsDraft { get; set; }
        public virtual JobType JobType { get; set; }
        public virtual JobCategory JobCategory { get; set; }
        public virtual JobPosistion JobPosistion { get; set; }
        public IList<JobBenefitJob> JobBenefitJob { get; set; }
        public virtual IList<JobKeySkillsJob> JobKeySkillsJob { get; set; }
    }
}
