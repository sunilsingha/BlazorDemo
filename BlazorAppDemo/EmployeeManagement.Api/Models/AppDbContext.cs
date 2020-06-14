using EmployeeManagement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace EmployeeManagement.Api.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Seed Data for Department table
            modelBuilder.Entity<Department>().HasData(
                new Department{ DepartmentId = 1, DepartmentName = "IT" });
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 2, DepartmentName = "HR" });
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 3, DepartmentName = "Payroll" });
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 4, DepartmentName = "Admin" });

            //Seed Data for Employee
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    EmployeeId = 1,
                    FirstName = "John",
                    LastName = "Hastings",
                    Email = "john@blazor.com",
                    DepartmentId = 1,
                    Gender = Gender.Male,
                    DateOfBirth = new DateTime(1980, 12, 14),
                    PhotoPath = "images/john.png"
                });            
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    EmployeeId = 2,
                    FirstName = "Don",
                    LastName = "Bosco",
                    Email = "don@blazor.com",
                    DepartmentId = 1,
                    Gender = Gender.Male,
                    DateOfBirth = new DateTime(1980, 1, 10),
                    PhotoPath = "images/don.png"
                });
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    EmployeeId = 3,
                    FirstName = "Ishu",
                    LastName = "Singh",
                    Email = "isu@blazor.com",
                    DepartmentId = 1,
                    Gender = Gender.Female,
                    DateOfBirth = new DateTime(2017, 11, 06),
                    PhotoPath = "images/isu.png"
                });
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    EmployeeId = 4,
                    FirstName = "Deepesh",
                    LastName = "Singh",
                    Email = "deepu@blazor.com",
                    DepartmentId = 1,
                    Gender = Gender.Male,
                    DateOfBirth = new DateTime(2014, 02, 14),
                    PhotoPath = "images/deepu.png"
                });
        }
    }
}
