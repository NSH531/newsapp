namespace News.Web
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using News.Model.Entity;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=db")
        {
        }

        public virtual DbSet<posts> posts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<posts>().ToTable("posts");
        }
    }
}
