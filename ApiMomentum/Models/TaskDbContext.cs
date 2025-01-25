using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ApiMomentum.Models
{
    public class TaskDbContext : DbContext
    {
        public TaskDbContext(DbContextOptions<TaskDbContext> options) : base(options) { }

        public DbSet<TaskItem> Tasks { get; set; }
    }
}
