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

        public virtual DbSet<Calendar> Calendars { get; set; } = null!;
        public virtual DbSet<Earning> Earnings { get; set; } = null!;
        public virtual DbSet<EstimatedInvestment> EstimatedInvestments { get; set; } = null!;
        public virtual DbSet<Investiment> Investiments { get; set; } = null!;
        public virtual DbSet<Profile> Profiles { get; set; } = null!;
        public virtual DbSet<Spending> Spendings { get; set; } = null!;
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

            modelBuilder.Entity<Calendar>(entity =>
            {
                entity.HasKey(e => e.Idcalendar);

                entity.Property(e => e.Idcalendar).HasColumnName("IDCalendar");

                entity.Property(e => e.CalendarDate)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CalendarMonth)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CalendarYear)
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Earning>(entity =>
            {
                entity.HasKey(e => e.Idearning);

                entity.Property(e => e.Idearning).HasColumnName("IDEarning");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ProfileId).HasColumnName("ProfileID");

                entity.HasOne(d => d.Profile)
                    .WithMany(p => p.Earnings)
                    .HasForeignKey(d => d.ProfileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Earnings_Profiles");
            });

            modelBuilder.Entity<EstimatedInvestment>(entity =>
            {
                entity.HasKey(e => e.IdestimatedInvestment);

                entity.Property(e => e.IdestimatedInvestment).HasColumnName("IDEstimatedInvestment");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CalendarId).HasColumnName("CalendarID");

                entity.Property(e => e.ProfileId).HasColumnName("ProfileID");

                entity.HasOne(d => d.Calendar)
                    .WithMany(p => p.EstimatedInvestments)
                    .HasForeignKey(d => d.CalendarId)
                    .HasConstraintName("FK_EstimatedInvestments_Calendars");

                entity.HasOne(d => d.Profile)
                    .WithMany(p => p.EstimatedInvestments)
                    .HasForeignKey(d => d.ProfileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EstimatedInvestments_Profiles1");
            });

            modelBuilder.Entity<Investiment>(entity =>
            {
                entity.HasKey(e => e.Idinvestiment);

                entity.Property(e => e.Idinvestiment).HasColumnName("IDInvestiment");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.EstimatedProfit).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProfileId).HasColumnName("ProfileID");

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.HasOne(d => d.Profile)
                    .WithMany(p => p.Investiments)
                    .HasForeignKey(d => d.ProfileId)
                    .HasConstraintName("FK_Investiments_Profiles");
            });

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

            modelBuilder.Entity<Spending>(entity =>
            {
                entity.HasKey(e => e.Idspending);

                entity.Property(e => e.Idspending).HasColumnName("IDSpending");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ProfileId).HasColumnName("ProfileID");

                entity.HasOne(d => d.Profile)
                    .WithMany(p => p.Spendings)
                    .HasForeignKey(d => d.ProfileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Spendings_Profiles");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.Iduser);

                entity.Property(e => e.Iduser).HasColumnName("IDUser");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Password)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
