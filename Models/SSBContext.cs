using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SouthStudioBlog.Models
{
    public class SSBContext : DbContext
    {
        public SSBContext(DbContextOptions<SSBContext> options)
            : base(options)
        { }

        public DbSet<User> Users { get; set; }

        public DbSet<Study> Studies { get; set; }

        public DbSet<Job> Jobs { get; set; }

        public DbSet<Post> Posts { get; set; }
    }
}
