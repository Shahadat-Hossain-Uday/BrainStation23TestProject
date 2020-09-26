using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BrainStation23TestProject.Models
{
    [Table("User")]
    public class User : BaseModel
    {
        [Key]
        public long UserID { get; set; }

        public string UserName { get; set; }
    }
}