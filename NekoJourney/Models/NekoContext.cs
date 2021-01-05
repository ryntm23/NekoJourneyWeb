using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace NekoJourney.Models
{
    public partial class NekoContext : DbContext
    {
        public NekoContext()
        {
        }

        public NekoContext(DbContextOptions<NekoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Admin> Admin { get; set; }
        public virtual DbSet<Review> Review { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>(entity =>
            {
                entity.HasKey(e => e.IdAdmin);

                entity.Property(e => e.IdAdmin)
                    .HasColumnName("ID_Admin")
                    .ValueGeneratedNever();

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nama)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NoHp)
                    .HasColumnName("NoHP")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Review>(entity =>
            {
                entity.HasKey(e => e.IdReview);

                entity.Property(e => e.IdReview)
                    .HasColumnName("ID_Review")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nama)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Review1)
                    .HasColumnName("Review")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.IdUser);

                entity.Property(e => e.IdUser)
                    .HasColumnName("ID_User")
                    .ValueGeneratedNever();

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nama)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
        }
    }
}
