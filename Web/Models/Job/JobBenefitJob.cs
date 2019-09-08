using System;
using System.Collections.Generic;

namespace JobWebsite.Models.Job
{
    public class JobBenefitJob
    {
        public int JobId { get; set; }
        public Job Job { get; set; }

        public int JobBenefitId { get; set; }
        public JobBenefit JobBenefit { get; set; }
    }
}