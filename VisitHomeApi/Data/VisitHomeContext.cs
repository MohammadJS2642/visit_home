using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using VisitHomeApi.Models;

namespace VisitHomeApi.Data
{
    public partial class VisitHomeContext : DbContext
    {
        // public VisitHomeContext()
        // {
        // }

        public VisitHomeContext(DbContextOptions<VisitHomeContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Home> Homes { get; set; }
        public virtual DbSet<Picture> Pictures { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=localhost;Database=VisitHome;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Home>(entity =>
            {
                entity.ToTable("Home");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Address).HasMaxLength(1000);

                entity.Property(e => e.Title).HasMaxLength(300);
            });

            // modelBuilder.Entity<Picture>(entity =>
            // {
            //     entity.Property(e => e.Id).ValueGeneratedNever();

            //     entity.HasOne(d => d.Home)
            //         .WithMany(p => p.PicturesNavigation)
            //         .HasForeignKey(d => d.HomeId)
            //         .HasConstraintName("FK__Pictures__HomeId__36B12243");
            // });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
