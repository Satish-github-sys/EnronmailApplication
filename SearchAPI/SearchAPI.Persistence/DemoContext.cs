using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using SearchAPI.Domain.Entities;

namespace SearchAPI.Persistence
{
    public partial class DemoContext : DbContext
    {
        public DemoContext()
        {
        }

        public DemoContext(DbContextOptions<DemoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Logs> Logs { get; set; }
        public virtual DbSet<Output> Output { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-NSTH8TK\\SQLEXPRESS;Initial Catalog=Demo;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Logs>(entity =>
            {
                entity.ToTable("Logs", "EventLogging");

                entity.Property(e => e.TimeStamp).HasColumnType("datetime");
            });

            modelBuilder.Entity<Output>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Body).HasColumnName("body");

                entity.Property(e => e.Column1).HasColumnName("column1");
                                
                entity.Property(e => e.XfileName).HasColumnName("XFileName");

                entity.Property(e => e.Xfolder).HasColumnName("XFolder");

                entity.Property(e => e.Xfrom).HasColumnName("XFrom");

                entity.Property(e => e.Xorigin).HasColumnName("XOrigin");

                entity.Property(e => e.Xto).HasColumnName("XTo");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
