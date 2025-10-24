using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace StokTakipEntityFrameWork
{
    public partial class DatabaseContext : DbContext
    {
        public DatabaseContext()
            : base("name=DatabaseContext")
        {
        }

        public virtual DbSet<Brands> Brands { get; set; }
        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brands>()
                .HasMany(e => e.Products)
                .WithRequired(e => e.Brands)
                .HasForeignKey(e => e.BrandID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Categories>()
                .HasMany(e => e.Products)
                .WithRequired(e => e.Categories)
                .HasForeignKey(e => e.CategoryID)
                .WillCascadeOnDelete(false);
        }
    }
}
