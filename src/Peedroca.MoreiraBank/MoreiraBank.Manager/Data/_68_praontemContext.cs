using System;
using System.Collections.Generic;
using System.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MoreiraBank.Manager.Data
{
    public partial class _68_praontemContext : DbContext
    {
        public _68_praontemContext()
        {
        }

        public _68_praontemContext(DbContextOptions<_68_praontemContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Profile> Profiles { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["PraOntem"].ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("68_devpraontem");

            modelBuilder.Entity<Profile>(entity =>
            {
                entity.HasKey(e => e.Idprofile);

                entity.Property(e => e.Idprofile).HasColumnName("IDProfile");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Profiles)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Profiles_Users1");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.Iduser);

                entity.Property(e => e.Iduser).HasColumnName("IDUser");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Password)
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
