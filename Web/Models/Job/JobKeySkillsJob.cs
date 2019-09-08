using System;
using System.Collections.Generic;

namespace JobWebsite.Models.Job
{
    public class JobKeySkillsJob
    {
        public int JobId { get; set; }
        public Job Job { get; set; }

        public int JobKeySkillId { get; set; }
        public JobKeySkill JobKeySkill { get; set; }
    }
}