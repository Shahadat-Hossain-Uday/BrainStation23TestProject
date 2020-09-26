using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BrainStation23TestProject.Models
{
    [Table("Post")]
    public class Post : BaseModel
    {
        [Key]
        public long postID { get; set; }

        public long AdminID { get; set; }
        public virtual AdminUser AdminUser { get; set; }

        public string PostName { get; set; }

        public DateTime PostedDate { get; set; }

        public long totalCmntCount { get; set; }

        [NotMapped]
        public List<Comment> comments { get; set; }
    }
}