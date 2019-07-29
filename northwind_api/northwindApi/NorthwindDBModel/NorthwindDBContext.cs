using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace northwindApi.NorthwindDBModel
{
    public partial class NorthwindDBContext : DbContext
    {
        public NorthwindDBContext()
        {
        }

        public NorthwindDBContext(DbContextOptions<NorthwindDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<EmployeeTerritory> EmployeeTerritory { get; set; }
        public virtual DbSet<Hobby> Hobby { get; set; }
        public virtual DbSet<OrderDetail> OrderDetail { get; set; }
        public virtual DbSet<OrderHeader> OrderHeader { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Region> Region { get; set; }
        public virtual DbSet<Shipper> Shipper { get; set; }
        public virtual DbSet<State> State { get; set; }
        public virtual DbSet<Supplier> Supplier { get; set; }
        public virtual DbSet<Territory> Territory { get; set; }
        public virtual DbSet<Title> Title { get; set; }
        public virtual DbSet<TitleOfCourtesy> TitleOfCourtesy { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=LAPTOP-F2RUMMJU\\SQLEXPRESS;Database=Northwind;Trusted_Connection=True;MultipleActiveResultSets=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Picture).HasColumnType("image");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.AnnualRevenue).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ContactName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ContactTitle)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.StateId)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ZipCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.State)
                    .WithMany(p => p.Customer)
                    .HasForeignKey(d => d.StateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("State_Customer_fk");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Birthdate).HasColumnType("datetime");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Extension)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.HireDate).HasColumnType("datetime");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Notes).HasColumnType("text");

                entity.Property(e => e.PersonalPhone)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Picture).HasColumnType("image");

                entity.Property(e => e.Salary).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.StateId)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ZipCode)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.HasOne(d => d.Hobby)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.HobbyId)
                    .HasConstraintName("Hobby_Employee_fk");

                entity.HasOne(d => d.ReportsToEmployee)
                    .WithMany(p => p.InverseReportsToEmployee)
                    .HasForeignKey(d => d.ReportsToEmployeeId)
                    .HasConstraintName("Employee_Employee_fk");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.StateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("State_Employee_fk");

                entity.HasOne(d => d.Title)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.TitleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Title_Employee_fk");

                entity.HasOne(d => d.TitleOfCourtesy)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.TitleOfCourtesyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("TitleOfCourtesy_Employee_fk");
            });

            modelBuilder.Entity<EmployeeTerritory>(entity =>
            {
                entity.HasIndex(e => new { e.EmployeeId, e.TerritoryId })
                    .HasName("EmployeeTerritory_idx")
                    .IsUnique();

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmployeeTerritory)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Employee_EmployeeTerritory_fk");

                entity.HasOne(d => d.Territory)
                    .WithMany(p => p.EmployeeTerritory)
                    .HasForeignKey(d => d.TerritoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Territory_EmployeeTerritory_fk");
            });

            modelBuilder.Entity<Hobby>(entity =>
            {
                entity.Property(e => e.HobbyName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.HasIndex(e => new { e.OrderHeaderId, e.ProductId })
                    .HasName("OrderDetail_idx")
                    .IsUnique();

                entity.Property(e => e.Discount).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(8, 2)");

                entity.HasOne(d => d.OrderHeader)
                    .WithMany(p => p.OrderDetail)
                    .HasForeignKey(d => d.OrderHeaderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("OrderHeader_OrderDetail_fk");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.OrderDetail)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Product_OrderDetail_fk");
            });

            modelBuilder.Entity<OrderHeader>(entity =>
            {
                entity.Property(e => e.Freight).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.OrderDateTime).HasColumnType("datetime");

                entity.Property(e => e.RequiredDate).HasColumnType("datetime");

                entity.Property(e => e.ShipAddress)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.ShipCity)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ShipName)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ShipStateId)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ShipZipCode)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ShippedDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.OrderHeader)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Customer_OrderHeader_fk");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.OrderHeader)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Employee_OrderHeader_fk");

                entity.HasOne(d => d.ShipState)
                    .WithMany(p => p.OrderHeader)
                    .HasForeignKey(d => d.ShipStateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("State_OrderHeader_fk");

                entity.HasOne(d => d.Shipper)
                    .WithMany(p => p.OrderHeader)
                    .HasForeignKey(d => d.ShipperId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Shipper_OrderHeader_fk");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(8, 2)");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Category_Product_fk");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.SupplierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Supplier_Product_fk");
            });

            modelBuilder.Entity<Region>(entity =>
            {
                entity.Property(e => e.RegionName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Shipper>(entity =>
            {
                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShipperName)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<State>(entity =>
            {
                entity.Property(e => e.StateId)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.StateName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Supplier>(entity =>
            {
                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ContactName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ContactTitle)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.HomePage)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.StateId)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ZipCode)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.HasOne(d => d.State)
                    .WithMany(p => p.Supplier)
                    .HasForeignKey(d => d.StateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("State_Supplier_fk");
            });

            modelBuilder.Entity<Territory>(entity =>
            {
                entity.Property(e => e.TerritoryName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.Territory)
                    .HasForeignKey(d => d.RegionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Region_Territory_fk");
            });

            modelBuilder.Entity<Title>(entity =>
            {
                entity.Property(e => e.TitleName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TitleOfCourtesy>(entity =>
            {
                entity.Property(e => e.TitleOfCourtesyName)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });
        }
    }
}
