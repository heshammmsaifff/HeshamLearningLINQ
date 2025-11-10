using System;
using System.Collections.Generic;
using System.Text;

namespace HeshamLearningLINQ
{
    public static class Data
    {
        public static List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();

            Employee employee = new Employee
            {
                Id = 1,
                FirstName = "Bob",
                LastName = "Jones",
                AnnualSalary = 60000,
                IsManager = true,
                DepartmentId = 1
            };
            employees.Add(employee);

            employee = new Employee
            {
                Id = 2,
                FirstName = "Sarah",
                LastName = "Jameson",
                AnnualSalary = 80000,
                IsManager = true,
                DepartmentId = 2
            };
            employees.Add(employee);

            employee = new Employee
            {
                Id = 3,
                FirstName = "Douglas",
                LastName = "Roberts",
                AnnualSalary = 40000,
                IsManager = false,
                DepartmentId = 2
            };
            employees.Add(employee);

            employee = new Employee
            {
                Id = 4,
                FirstName = "Jane",
                LastName = "Stevens",
                AnnualSalary = 30000,
                IsManager = false,
                DepartmentId = 3
            };
            employees.Add(employee);

            return employees;
        }

        public static List<Department> GetDepartments()
        {
            List<Department> departments = new List<Department>();
            Department department = new Department
            {
                Id = 1,
                ShortName = "HR",
                LongName = "Human Resources"
            };
            departments.Add(department);
            department = new Department
            {
                Id = 2,
                ShortName = "IT",
                LongName = "Information Technology"
            };
            departments.Add(department);
            department = new Department
            {
                Id = 3,
                ShortName = "FN",
                LongName = "Finance"
            };
            departments.Add(department);
            return departments;
        }
    }
}
