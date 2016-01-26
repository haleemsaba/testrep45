namespace WebApplication1.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Customer : DbContext
    {
        public Customer()
            : base("name=Customer")
        {
        }

        public virtual DbSet<C_CustomerContactDetails> C_CustomerContactDetails { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
