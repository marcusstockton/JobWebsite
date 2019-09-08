using System;
using System.Collections.Generic;

namespace JobWebsite.Models.Job
{
    public class JobBenefit : Base
    {
	    public string Description { get; set; } //Pension/CyccleToWork
        public IList<JobBenefitJob> JobBenefitJob { get; set; }
    }
}