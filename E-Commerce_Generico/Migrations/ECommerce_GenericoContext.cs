using System;
using System.Collections.Generic;
using E_Commerce_Generico.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace E_Commerce_Generico.Migrations
{
    public partial class ECommerce_GenericoContext : DbContext
    {
        public ECommerce_GenericoContext()
        {
        }

        public ECommerce_GenericoContext(DbContextOptions<ECommerce_GenericoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<UsersComplementaryInformation> UsersComplementaryInformations { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-8OMNJR4\\SQLEXPRESS;Database=E-Commerce_Generico;Trusted_Connection=true;MultipleActiveResultSets=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.ProductId).HasColumnName("productID");

                entity.Property(e => e.ProductBrand)
                    .HasMaxLength(50)
                    .HasColumnName("productBrand");

                entity.Property(e => e.ProductCategory)
                    .HasMaxLength(60)
                    .HasColumnName("productCategory");

                entity.Property(e => e.ProductImage)
                    .HasColumnType("image")
                    .HasColumnName("productImage");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(50)
                    .HasColumnName("productName");

                entity.Property(e => e.ProductPrice)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("productPrice");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.UserId).HasColumnName("userID");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .HasColumnName("userName");

                entity.Property(e => e.UserPassword)
                    .HasMaxLength(50)
                    .HasColumnName("userPassword");

                entity.Property(e => e.UserRole)
                    .HasMaxLength(25)
                    .HasColumnName("userRole");
            });

            modelBuilder.Entity<UsersComplementaryInformation>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__UsersCom__CB9A1CDF78459820");

                entity.ToTable("UsersComplementaryInformation");

                entity.Property(e => e.UserId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("userID");

                entity.Property(e => e.UserAddress)
                    .HasMaxLength(60)
                    .HasColumnName("userAddress");

                entity.Property(e => e.UserFirstName)
                    .HasMaxLength(50)
                    .HasColumnName("userFirstName");

                entity.Property(e => e.UserPhone)
                    .HasMaxLength(30)
                    .HasColumnName("userPhone");

                entity.Property(e => e.UserSurname)
                    .HasMaxLength(50)
                    .HasColumnName("userSurname");

                entity.HasOne(d => d.User)
                    .WithOne(p => p.UsersComplementaryInformation)
                    .HasForeignKey<UsersComplementaryInformation>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__UsersComp__userI__3A81B327");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
