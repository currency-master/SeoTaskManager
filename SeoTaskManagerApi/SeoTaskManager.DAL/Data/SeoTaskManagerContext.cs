using Microsoft.EntityFrameworkCore;
using SeoTaskManager.Domain.Models;

namespace SeoTaskManager.DAL.Data
{
    public class SeoTaskManagerContext : DbContext
    {
        public SeoTaskManagerContext(DbContextOptions<SeoTaskManagerContext> options)
            : base(options)
        {
        }

        public DbSet<UserTask> UserTasks { get; set; }
    }
}