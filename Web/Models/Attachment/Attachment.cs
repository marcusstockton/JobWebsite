using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobWebsite.Models.Attachment
{
    public class Attachment : Base
    {
        public string FileName { get; set; }
        public string FileType { get; set; }
        public string FileLocation { get; set; }
        public ApplicationUser User{get;set;}
        public AttachmentType AttachmentType { get; set; }
    }
}
