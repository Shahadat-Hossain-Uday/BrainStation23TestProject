using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BrainStation23TestProject.Models
{
    [Table("AdminUser")]
    public class AdminUser : BaseModel
    {
        [Key]
        public long AdminID { get; set; }

        public String AdminName { get; set; }

    }
}