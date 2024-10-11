

using Microsoft.EntityFrameworkCore;
using project_cls.DAL.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace project_cls.DAL
{
    public class AppDbContext : DbContext
    {


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-36H4QAR\\SQLEXPRESS;Initial Catalog=\" ProjectCls\";Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
            
    }


        public DbSet<Bill> Bills { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductBill> ProductBills { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductBill>().HasKey(p
            => new { p.ProductId, p.BillId });




            //base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<Category>()
            //    .HasMany(c => c.Products)
            //    .WithOne(p => p.Category)
            //    .HasForeignKey(p => p.CategoryId);
        }




    }
}
