using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace JobWebsite.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public virtual UserType UserType { get; set; }
        public IList<Attachment.Attachment> Attachments { get; set; }
    }
}

