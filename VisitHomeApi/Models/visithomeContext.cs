using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace VisitHomeApi.Models
{
    public partial class visithomeContext : DbContext
    {
        public visithomeContext()
        {
        }

        public visithomeContext(DbContextOptions<visithomeContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Home> Homes { get; set; }


        #region created with ef core
        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // {
        //             if (!optionsBuilder.IsConfigured)
        //             {
        // #warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        //                 optionsBuilder.UseMySQL("server=localhost;Port=3306;user=root;password=1378@;database=visithome");
        //             }
        // }

        // protected override void OnModelCreating(ModelBuilder modelBuilder)
        // {
        //     modelBuilder.Entity<Home>(entity =>
        //     {
        //         entity.ToTable("home");

        //         entity.Property(e => e.Address).HasMaxLength(500);

        //         entity.Property(e => e.Parking).HasColumnType("bit(1)");

        //         entity.Property(e => e.Warehouse).HasColumnType("bit(1)");
        //     });

        //     OnModelCreatingPartial(modelBuilder);
        // }

        // partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
    #endregion
}
