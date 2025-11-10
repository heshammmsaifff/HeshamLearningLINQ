using System;
using System.Collections.Generic;

namespace HeshamLearningLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = Data.GetEmployees();
            List<Department> departments = Data.GetDepartments();

            bool keepRunning = true;

            while (keepRunning)
            {
                Console.WriteLine("\n---- Main Menu ----");
                Console.WriteLine("1 - Show Employees");
                Console.WriteLine("2 - Show Departments");
                Console.WriteLine("3 - Employees in IT");
                Console.WriteLine("4 - Employees in Finance");
                Console.WriteLine("5 - Employees in HR");
                Console.WriteLine("6 - Salary > 40000");
                Console.WriteLine("7 - Salary <= 40000");
                Console.WriteLine("8 - Employees with Department Names");
                Console.WriteLine("9 - All Managers");
                Console.WriteLine("10 - Exit");

                Console.Write("\nEnter choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        EmployeeQueries.ShowAllEmployees(employees);
                        break;
                    case "2":
                        DepartmentQueries.ShowDepartments(departments);
                        break;
                    case "3":
                        EmployeeQueries.ShowEmployeesByDepartment(employees, departments, "IT");
                        break;
                    case "4":
                        EmployeeQueries.ShowEmployeesByDepartment(employees, departments, "FN");
                        break;
                    case "5":
                        EmployeeQueries.ShowEmployeesByDepartment(employees, departments, "HR");
                        break;
                    case "6":
                        EmployeeQueries.ShowEmployeesBySalary(employees, true, 40000);
                        break;
                    case "7":
                        EmployeeQueries.ShowEmployeesBySalary(employees, false, 40000);
                        break;
                    case "8":
                        EmployeeQueries.ShowEmployeesWithDepartments(employees, departments);
                        break;
                    case "9":
                        EmployeeQueries.ShowManagers(employees);
                        break;
                    case "10":
                        keepRunning = false;
                        Console.WriteLine("\nOk, Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }

                if (keepRunning)
                {
                    Console.Write("\nDo you want to continue? (y/n): ");
                    string again = Console.ReadLine()?.Trim().ToLower();
                    keepRunning = again == "y";
                }
            }
        }
    }
}
