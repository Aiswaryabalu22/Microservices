using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webApiDemo.models
{
    public class ProjectAppDbContext : DbContext
    {
        public ProjectAppDbContext(DbContextOptions<ProjectAppDbContext> options) : base(options)
        {

        }

        public DbSet<Project> Projects { get; set; }
    }
}
