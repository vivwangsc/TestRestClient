using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace TestRestClient
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<BA_ICD10> BA_ICD10 { get; set; }
        public virtual DbSet<BA_KSB> BA_KSB { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BA_ICD10>()
                .Property(e => e.BM)
                .IsUnicode(false);

            modelBuilder.Entity<BA_ICD10>()
                .Property(e => e.MC)
                .IsUnicode(false);

            modelBuilder.Entity<BA_ICD10>()
                .Property(e => e.PYM)
                .IsUnicode(false);

            modelBuilder.Entity<BA_KSB>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<BA_KSB>()
                .Property(e => e.MC)
                .IsUnicode(false);

            modelBuilder.Entity<BA_KSB>()
                .Property(e => e.ZKYS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BA_KSB>()
                .Property(e => e.ZKHS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BA_KSB>()
                .Property(e => e.KZR)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
