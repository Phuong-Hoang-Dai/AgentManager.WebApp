using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Data;

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
            modelBuilder.Entity<DeliveryNoteDetail>().HasKey(x => new { x.ProductId, x.DeliveryNoteId});


            //Sua ten cac bang cua Identity
            FixNameIdentityTables(modelBuilder);
        }
        DbSet<Agent>? Agents { get; set; }
        DbSet<AgentCategory>? AgentCategories { get; set; }
        DbSet<DeliveryNote>? DeliveryNotes { get; set; }
        DbSet<DeliveryNoteDetail>? DeliveryNoteDetails { get; set; }
        DbSet<Department>? Departments { get; set; }
        DbSet<District>? Districts { get; set; }
        DbSet<Position>? Positions { get; set; }
        DbSet<Product>? Products { get; set; }
        DbSet<ProductCategory>? ProductCategories { get; set; }
        DbSet<Receipt>? Receipts { get; set; }
        DbSet<Staff>? Staffs { get; set; }




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
