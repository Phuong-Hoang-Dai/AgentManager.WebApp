using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AgentManager.WebApp.Models
{
    public class AgentManagerDbContext : IdentityDbContext<Staff>
    {
        public AgentManagerDbContext(DbContextOptions<AgentManagerDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Tao khoa cho cac bang cua Identity
            base.OnModelCreating(modelBuilder);

            //Sua ten cac bang cua Identity
            FixNameIdentityTables(modelBuilder);
        }
        DbSet<Department> Departments { get; set; }
        DbSet<Position> Positions { get; set; }
        DbSet<Staff> Staffs { get; set; }






        private static void FixNameIdentityTables(ModelBuilder modelBuilder)
        {
            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                var tablename = entityType.GetTableName();
                if (tablename.StartsWith("AspNet"))
                {
                    entityType.SetTableName(tablename.Substring(6));
                }
            }
        }
    }
}
