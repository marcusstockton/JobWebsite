using System;
using System.ComponentModel.DataAnnotations;

namespace JobWebsite.Models
{
    public abstract class Base
    {
        [Key]
        public int Id { get; set; }
        public virtual ApplicationUser CreatedBy{get;set;}
        public DateTime CreatedDate{get;set;}
        public virtual ApplicationUser UpdatedBy{get;set;}
        public DateTime? UpdatedDate{get;set;}
        public bool Active { get; set; }
    }
}