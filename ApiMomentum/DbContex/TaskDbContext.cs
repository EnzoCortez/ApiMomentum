using ApiMomentum.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace TaskAPI.Models
{
    public class TaskDbContext : DbContext
    {
        public TaskDbContext(DbContextOptions<TaskDbContext> options) : base(options) { }

        public DbSet<TaskItem> Tasks { get; set; }
    }
}
