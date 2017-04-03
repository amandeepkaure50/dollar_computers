namespace Dollar_Computers.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ProductContent : DbContext
    {
        public ProductContent()
            : base("name=ProductConnection")
        {
        }

        public virtual DbSet<PRODUCT> PRODUCTS { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PRODUCT>()
                .Property(e => e.cost)
                .HasPrecision(19, 4);
        }
    }
}
