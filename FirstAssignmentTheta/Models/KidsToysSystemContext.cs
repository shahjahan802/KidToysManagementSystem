using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FirstAssignmentTheta.Models
{
    public partial class KidsToysSystemContext : DbContext
    {
        public KidsToysSystemContext()
        {
        }

        public KidsToysSystemContext(DbContextOptions<KidsToysSystemContext> options)
            : base(options)
        {
        }

        public virtual DbSet<EmailSender> EmailSender { get; set; }
        public virtual DbSet<ToysProperties> ToysProperties { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlite("Data Source=C:\\Users\\JS\\source\\repos\\FirstAssignmentTheta-copy\\KidsToysSystem.db;");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmailSender>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Body).HasColumnType("nvarchar(50)");

                entity.Property(e => e.EmailFrom).HasColumnType("nvarchar(50)");

                entity.Property(e => e.EmailTo).HasColumnType("nvarchar(50)");

                entity.Property(e => e.Subject).HasColumnType("nvarchar(50)");
            });

            modelBuilder.Entity<ToysProperties>(entity =>
            {
                //entity.Property(e => e.Id) .HasColumnName("id").ValueGeneratedNever();

                entity.Property(e => e.Age).HasColumnType("int");

                entity.Property(e => e.Color).HasColumnType("nvarchar(50)");

                entity.Property(e => e.Name).HasColumnType("nvarchar(50)");

                entity.Property(e => e.Price).HasColumnType("nvarchar(50)");

                entity.Property(e => e.Weight).HasColumnType("nvarchar(50)");

                entity.Property(e => e.Email).HasColumnType("nvarchar(50)");
            });
        }
    }
}
