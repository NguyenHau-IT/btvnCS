using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QLSV.Model
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model2")
        {
        }

        public virtual DbSet<FACULTY> FACULTies { get; set; }
        public virtual DbSet<STUDENT> STUDENTs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FACULTY>()
                .Property(e => e.FACULTYID)
                .IsUnicode(false);

            modelBuilder.Entity<FACULTY>()
                .HasMany(e => e.STUDENTs)
                .WithRequired(e => e.FACULTY)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<STUDENT>()
                .Property(e => e.STUDENTID)
                .IsUnicode(false);

            modelBuilder.Entity<STUDENT>()
                .Property(e => e.FACULTYID)
                .IsUnicode(false);
        }
    }
}
