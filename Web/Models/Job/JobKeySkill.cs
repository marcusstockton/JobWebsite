using System;
using System.Collections.Generic;

namespace JobWebsite.Models.Job
{
    public class JobKeySkill : Base
    {
	    public string Description { get; set; } // ASP.NET/Sales Experience/Customer Service

        public IList<JobKeySkillsJob> JobKeySkillsJob { get; set; }
    }
}