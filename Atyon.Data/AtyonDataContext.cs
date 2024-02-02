using Atyon.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Atyon.Data
{
    public partial class AtyonDataContext : DbContext
    {
        public AtyonDataContext()
        {
        }

        public AtyonDataContext(DbContextOptions<AtyonDataContext> options)
        : base(options)
        {
        }

        public virtual DbSet<City> Cities { get; set; } = null!;
        public virtual DbSet<Company> Companies { get; set; } = null!;
        public virtual DbSet<Facility> Facilities { get; set; } = null!;
        public virtual DbSet<FacilityQualificationType> FacilityQualificationTypes { get; set; } = null!;
        public virtual DbSet<FacilityType> FacilityTypes { get; set; } = null!;
        public virtual DbSet<Manufacture> Manufactures { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<Town> Towns { get; set; } = null!;
        public virtual DbSet<Waste> Wastes { get; set; } = null!;
        public virtual DbSet<WasteStock> WasteStocks { get; set; } = null!;
        public virtual DbSet<WasteType> WasteTypes { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.;Database=atyon;Trusted_Connection=false;User Id=atyon;Password=1;", x => x.UseNetTopologySuite());
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>(entity =>
            {
                entity.HasKey(e => e.CityId)
                    .HasName("city_pk");

                entity.Property(e => e.CityId).ValueGeneratedNever();

                entity.Property(e => e.DateOfRecord).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.CityCodeNavigation)
                    .WithOne(p => p.City)
                    .HasForeignKey<City>(d => d.CityCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("city_company_fk");

                entity.HasOne(d => d.CityCode1)
                    .WithOne(p => p.City)
                    .HasForeignKey<City>(d => d.CityCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("city_facility_fk");

                entity.HasOne(d => d.CityCode2)
                    .WithOne(p => p.City)
                    .HasForeignKey<City>(d => d.CityCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("city_manufacture_fk");
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.HasKey(e => e.CompanyId)
                    .HasName("company_pk");

                entity.Property(e => e.CompanyId).ValueGeneratedNever();

                entity.Property(e => e.DatOfRecord).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.CompanyCodeNavigation)
                    .WithMany(p => p.Companies)
                    .HasForeignKey(d => d.CompanyCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("company_facility_fk");
            });

            modelBuilder.Entity<Facility>(entity =>
            {
                entity.HasKey(e => e.FacilityId)
                    .HasName("facility_pk");

                entity.Property(e => e.FacilityId).ValueGeneratedNever();

                entity.Property(e => e.DateOfRecord).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<FacilityQualificationType>(entity =>
            {
                entity.HasKey(e => e.FacilityQualificationTypeId)
                    .HasName("facilityqualification_pk");

                entity.Property(e => e.FacilityQualificationTypeId).ValueGeneratedNever();

                entity.Property(e => e.DateOfRecord).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.FacilityQualificationTypeCodeNavigation)
                    .WithMany(p => p.FacilityQualificationTypes)
                    .HasForeignKey(d => d.FacilityQualificationTypeCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("facilityqualificationtype_facility_fk");
            });

            modelBuilder.Entity<FacilityType>(entity =>
            {
                entity.HasKey(e => e.FacilityTypeId)
                    .HasName("facilitytype_pk");

                entity.Property(e => e.FacilityTypeId).ValueGeneratedNever();

                entity.Property(e => e.DateOfRecord).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.FacilityTypeCodeNavigation)
                    .WithMany(p => p.FacilityTypes)
                    .HasForeignKey(d => d.FacilityTypeCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("facilitytype_facilityqualificationtype_fk");
            });

            modelBuilder.Entity<Manufacture>(entity =>
            {
                entity.HasKey(e => e.ManufactureId)
                    .HasName("manufacture_pk");

                entity.Property(e => e.ManufactureId).ValueGeneratedNever();

                entity.Property(e => e.DateOfRecord).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.ManufactureCodeNavigation)
                    .WithMany(p => p.Manufactures)
                    .HasForeignKey(d => d.ManufactureCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("manufacture_company_fk");

                entity.HasOne(d => d.ManufactureCode1)
                    .WithMany(p => p.Manufactures)
                    .HasForeignKey(d => d.ManufactureCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("manufacture_facility_fk");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.ProductId)
                    .HasName("product_pk");

                entity.Property(e => e.ProductId).ValueGeneratedNever();

                entity.Property(e => e.DateOfRecord).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.ProductCodeNavigation)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.ProductCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("product_manufacture_fk");
            });

            modelBuilder.Entity<Town>(entity =>
            {
                entity.HasKey(e => e.TownId)
                    .HasName("town_pk");

                entity.Property(e => e.TownId).ValueGeneratedNever();

                entity.Property(e => e.DateOfRecord).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.TownCodeNavigation)
                    .WithOne(p => p.Town)
                    .HasPrincipalKey<City>(p => p.CityCode)
                    .HasForeignKey<Town>(d => d.TownCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("town_city_fk");
            });

            modelBuilder.Entity<Waste>(entity =>
            {
                entity.HasKey(e => e.WasteId)
                    .HasName("waste_pk");

                entity.Property(e => e.WasteId).ValueGeneratedNever();

                entity.Property(e => e.DateOfRecord).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.WasteIdNavigation)
                    .WithOne(p => p.Waste)
                    .HasForeignKey<Waste>(d => d.WasteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("waste_wastestock_fk");
            });

            modelBuilder.Entity<WasteStock>(entity =>
            {
                entity.HasKey(e => e.WasteStockId)
                    .HasName("wastestock_pk");

                entity.Property(e => e.WasteStockId).ValueGeneratedNever();

                entity.Property(e => e.DateOfRecord).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.WasteStockCodeNavigation)
                    .WithMany(p => p.WasteStocks)
                    .HasForeignKey(d => d.WasteStockCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("wastestock_facility_fk");
            });

            modelBuilder.Entity<WasteType>(entity =>
            {
                entity.HasKey(e => e.WasteTypeId)
                    .HasName("wastetype_pk");

                entity.Property(e => e.WasteTypeId).ValueGeneratedNever();

                entity.Property(e => e.DateOfRecord).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.WasteTypeCodeNavigation)
                    .WithMany(p => p.WasteTypes)
                    .HasForeignKey(d => d.WasteTypeCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("wastetype_waste_fk");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
