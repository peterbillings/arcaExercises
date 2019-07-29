using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DatabaseConnectionPractice.DB01Model
{
    public partial class db01 : DbContext
    {
        public db01()
        {
        }

        public db01(DbContextOptions<db01> options)
            : base(options)
        {
        }

        public virtual DbSet<Automaker> Automaker { get; set; }
        public virtual DbSet<Car> Car { get; set; }
        public virtual DbSet<Departments> Departments { get; set; }
        public virtual DbSet<EmployeePhoneNumbers> EmployeePhoneNumbers { get; set; }
        public virtual DbSet<Employees> Employees { get; set; }
        public virtual DbSet<Nicknames> Nicknames { get; set; }
        public virtual DbSet<PhoneNumbers> PhoneNumbers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured) 
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=LAPTOP-F2RUMMJU\\SQLEXPRESS;Database=db01;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<Automaker>(entity =>
            {
                entity.ToTable("automaker");

                entity.Property(e => e.AutomakerId)
                    .HasColumnName("automakerID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AutomakerName)
                    .IsRequired()
                    .HasColumnName("automakerName")
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Car>(entity =>
            {
                entity.ToTable("car");

                entity.Property(e => e.CarId)
                    .HasColumnName("carID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AutomakerId).HasColumnName("automakerID");

                entity.Property(e => e.Make)
                    .IsRequired()
                    .HasColumnName("make")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Model).HasColumnName("model");
            });

            modelBuilder.Entity<Departments>(entity =>
            {
                entity.HasKey(e => e.DeptId)
                    .HasName("PK__Departme__0148818E61CE210C");

                entity.Property(e => e.DeptId)
                    .HasColumnName("DeptID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DeptName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmployeePhoneNumbers>(entity =>
            {
                entity.HasKey(e => new { e.EmployeeId, e.PhoneNumberId })
                    .HasName("EmployeePhoneNumbersPK");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.PhoneNumberId).HasColumnName("PhoneNumberID");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmployeePhoneNumbers)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EmployeeP__Emplo__45F365D3");

                entity.HasOne(d => d.PhoneNumber)
                    .WithMany(p => p.EmployeePhoneNumbers)
                    .HasForeignKey(d => d.PhoneNumberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EmployeeP__Phone__46E78A0C");
            });

            modelBuilder.Entity<Employees>(entity =>
            {
                entity.HasKey(e => e.EmpId)
                    .HasName("PK__Employee__AF2DBA79D53EE899");

                entity.Property(e => e.EmpId)
                    .HasColumnName("EmpID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DeptId).HasColumnName("DeptID");

                entity.Property(e => e.EmpFirstName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EmpLastName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EmpSalary).HasColumnType("decimal(9, 2)");

                entity.HasOne(d => d.Dept)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.DeptId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Employees__DeptI__3E52440B");
            });

            modelBuilder.Entity<Nicknames>(entity =>
            {
                entity.HasKey(e => e.NicknameId)
                    .HasName("PK__Nickname__E789315EABF7A2FB");

                entity.Property(e => e.NicknameId)
                    .HasColumnName("NicknameID")
                    .ValueGeneratedNever();

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.Nickname)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.Emp)
                    .WithMany(p => p.Nicknames)
                    .HasForeignKey(d => d.EmpId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Nicknames__EmpID__412EB0B6");
            });

            modelBuilder.Entity<PhoneNumbers>(entity =>
            {
                entity.HasKey(e => e.PhoneNumberId)
                    .HasName("PK__PhoneNum__D2D34FB1153E8A9D");

                entity.Property(e => e.PhoneNumberId)
                    .HasColumnName("PhoneNumberID")
                    .ValueGeneratedNever();

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumberType)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });
        }
    }
}
