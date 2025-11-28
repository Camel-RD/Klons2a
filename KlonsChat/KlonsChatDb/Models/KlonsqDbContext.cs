using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlonsChatDb.Models
{
    public partial class KlonsqDbContext : DbContext
    {
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Item> Items { get; set; }

        public KlonsqDbContext() : base()
        {
        }
        public KlonsqDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var cb = new SqliteConnectionStringBuilder();
                cb.DataSource = @"D:\A1-docs\c_net\KlonsQ\Data\klonsChat.db";
                var cs = cb.ToString();
                optionsBuilder.UseSqlite(cs);
                //optionsBuilder.UseLoggerFactory(_myLoggerFactory).EnableSensitiveDataLogging();
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("Users");
                entity.HasIndex(e => e.Guid, "USERS_IDX_GUID");
            });
            modelBuilder.Entity<Item>(entity =>
            {
                entity.ToTable("Items");
                entity.HasIndex(e => e.DateCreated, "ITEM_IDX_DATECREATED");
                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasDefaultValue(EItemType.QuestionNew);
                entity.HasOne(e => e.User)
                    .WithMany(e => e.Items)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ITEM_USERID");
                entity.Property(e => e.IsDeleted)
                    .HasDefaultValue(false);
            });


            OnModelCreatingPartial(modelBuilder);


        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    }
}
