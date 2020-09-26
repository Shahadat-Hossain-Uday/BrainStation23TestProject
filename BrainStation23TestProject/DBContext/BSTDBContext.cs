using BrainStation23TestProject.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BrainStation23TestProject.DBContext
{
    public class BSTDBContext : DbContext
    {
        public BSTDBContext() : base("BSTestConnection")
        {

        }

        public DbSet<AdminUser> AdminUser { get; set; }
        public DbSet<Comment> Comment { get; set; }
        public DbSet<Post> Post { get; set; }
        public DbSet<User> User { get; set; }
    }
}