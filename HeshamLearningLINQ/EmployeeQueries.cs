using System;
using System.Collections.Generic;
using System.Linq;

namespace HeshamLearningLINQ
{
    public static class EmployeeQueries
    {
        public static void ShowAllEmployees(List<Employee> employees)
        {
            Console.WriteLine("\n---- Employees ----");
            foreach (var emp in employees)
            {
                Console.WriteLine($"{emp.FirstName} {emp.LastName,-20} - Salary: {emp.AnnualSalary}");
            }
        }

        public static void ShowEmployeesByDepartment(List<Employee> employees, List<Department> departments, string deptShort)
        {
            var query = from emp in employees
                        join dep in departments on emp.DepartmentId equals dep.Id
                        where dep.ShortName == deptShort
                        select emp;

            Console.WriteLine($"\n---- Employees in {deptShort} ----");
            foreach (var emp in query)
            {
                Console.WriteLine($"{emp.FirstName} {emp.LastName} - {emp.AnnualSalary}");
            }
        }

        public static void ShowEmployeesBySalary(List<Employee> employees, bool moreThan, int salary)
        {
            IEnumerable<Employee> query;

            if (moreThan)
                query = employees.Where(e => e.AnnualSalary > salary);
            else
                query = employees.Where(e => e.AnnualSalary <= salary);

            Console.WriteLine($"\n---- Employees with Salary {(moreThan ? ">" : "<=")} {salary} ----");
            foreach (var emp in query)
            {
                Console.WriteLine($"{emp.FirstName} {emp.LastName} - {emp.AnnualSalary}");
            }
        }

        public static void ShowEmployeesWithDepartments(List<Employee> employees, List<Department> departments)
        {
            var query = from emp in employees
                        join dep in departments on emp.DepartmentId equals dep.Id
                        select new
                        {
                            Name = emp.FirstName + " " + emp.LastName,
                            Department = dep.LongName,
                            Salary = emp.AnnualSalary
                        };

            Console.WriteLine("\n---- All Employees with Department Names ----");
            foreach (var item in query)
            {
                Console.WriteLine($"{item.Name,-20} | {item.Department,-25} | Salary: {item.Salary}");
            }
        }

        public static void ShowManagers(List<Employee> employees)
        {
            var query = employees.Where(e => e.IsManager);

            Console.WriteLine("\n---- All Managers ----");
            foreach (var emp in query)
            {
                Console.WriteLine($"{emp.FirstName} {emp.LastName} - {emp.AnnualSalary}");
            }
        }
    }
}
