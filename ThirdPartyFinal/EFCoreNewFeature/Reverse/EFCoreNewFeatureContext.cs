using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Reverse
{
    public partial class EFCoreNewFeatureContext : DbContext
    {
        public EFCoreNewFeatureContext()
        {
        }

        public EFCoreNewFeatureContext(DbContextOptions<EFCoreNewFeatureContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Addresses> Addresses { get; set; }
        public virtual DbSet<People> People { get; set; }
        public virtual DbSet<VwTemp> VwTemp { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=.;initial catalog=EFCoreNewFeature;integrated security=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Addresses>(entity =>
            {
                entity.HasIndex(e => e.PersonId);

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Addresses)
                    .HasForeignKey(d => d.PersonId);
            });

            modelBuilder.Entity<VwTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_Temp");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
