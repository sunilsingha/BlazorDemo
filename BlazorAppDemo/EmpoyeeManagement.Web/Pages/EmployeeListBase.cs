using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagement.Models;

namespace EmpoyeeManagement.Web.Pages
{
    public class EmployeeListBase : ComponentBase
    {
        public IEnumerable<Employee> Employees { get; set; }

        protected override Task OnInitializedAsync()
        {
            LoadEmployees();
            return base.OnInitializedAsync();
        }

        private void LoadEmployees()
        {
            Employee e1 = new Employee()
            {
                EmployeeId = 1,
                FirstName = "John",
                LastName = "Hastings",
                Email = "john@blazor.com",
                Department = new Department() { DepartmentId = 1, DepartmentName = "HR"},
                Gender = Gender.Male,
                DateOfBirth = new DateTime(1980,12,14),
                PhotoPath = "images/john.png"
            };

            Employee e2 = new Employee()
            {
                EmployeeId = 2,
                FirstName = "Don",
                LastName = "Bosco",
                Email = "don@blazor.com",
                Department = new Department() { DepartmentId = 1, DepartmentName = "DM" },
                Gender = Gender.Male,
                DateOfBirth = new DateTime(1980, 1, 10),
                PhotoPath = "images/don.png"
            };

            Employee e3 = new Employee()
            {
                EmployeeId = 3,
                FirstName = "Ishu",
                LastName = "Singh",
                Email = "isu@blazor.com",
                Department = new Department() { DepartmentId = 1, DepartmentName = "MD" },
                Gender = Gender.Female,
                DateOfBirth = new DateTime(2017, 11, 06),
                PhotoPath = "images/isu.png"
            };

            Employee e4 = new Employee()
            {
                EmployeeId = 3,
                FirstName = "Deepesh",
                LastName = "Singh",
                Email = "deepu@blazor.com",
                Department = new Department() { DepartmentId = 1, DepartmentName = "MD" },
                Gender = Gender.Male,
                DateOfBirth = new DateTime(2014, 02, 14),
                PhotoPath = "images/deepu.png"
            };

            Employees = new List<Employee> { e1, e2, e3, e4 };

        }
    }
}
