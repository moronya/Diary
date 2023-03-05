using Diary.Models;
using Microsoft.EntityFrameworkCore;

namespace Diary.DAL
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { } 
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<TaskActivity> taskActivities { get; set; } 
    }
}
