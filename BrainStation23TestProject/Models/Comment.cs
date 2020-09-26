using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BrainStation23TestProject.Models
{
    [Table("Comment")]
    public class Comment : BaseModel
    {
        [Key]
        public long CommentID { get; set; }

        public long postID { get; set; }
        public virtual Post Post { get; set; }

        public long UserID { get; set; }
        public virtual User User { get; set; }

        public string Comments { get; set; }

        public long Like { get; set; }

        public long Dislike { get; set; }

        [NotMapped]
        public bool like { get; set; }

        [NotMapped]
        public bool dislike { get; set; }

    }
}