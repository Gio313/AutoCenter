using AutoCenter.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace AutoCenter.Repository
{
    public class AutoCenterDbContext : DbContext
    {
        public DbSet<AdministrationEmployee> AdministrationEmployees { get; set; }
        public DbSet<Automobile> Automobiles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<DriversInOrderDetail> DriversInOrderDetails { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<OrderStatus> OrderStatuses { get; set; }
        public DbSet<Technician> Technicians { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.\sqlexpress;Initial Catalog=AutoCenter2020;Integrated Security=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasIndex(x => x.PersonalNumber).IsUnique();
            modelBuilder.Entity<Customer>().HasIndex(x => x.PersonalNumber).IsUnique();
            modelBuilder.Entity<OrderDetail>().HasIndex(x => new { x.OrderID, x.AutomobileID }).IsUnique();
            modelBuilder.Entity<OrderStatus>().HasIndex(x => x.StatusName).IsUnique();
            modelBuilder.Entity<Category>().HasIndex(x => x.CategoryName).IsUnique();
            modelBuilder.Entity<Customer>().ToTable("Customers").Property(x => x.IsDeleted).HasDefaultValue(false);
            modelBuilder.Entity<Employee>().ToTable("Employees").Property(x => x.IsDeleted).HasDefaultValue(false);
            modelBuilder.Entity<Automobile>().ToTable("Automobiles").Property(x => x.IsDeleted).HasDefaultValue(false);
            modelBuilder.Entity<Category>().ToTable("Categories").Property(x => x.IsDeleted).HasDefaultValue(false);
            modelBuilder.Entity<OrderStatus>().ToTable("OrderStatuses").Property(x => x.IsDeleted).HasDefaultValue(false);
            modelBuilder.Entity<Customer>().Property(x => x.RecordDate).HasDefaultValueSql("getdate()");
            modelBuilder.Entity<Automobile>().Property(x => x.RecordDate).HasDefaultValueSql("getdate()");
        }
    }
}
