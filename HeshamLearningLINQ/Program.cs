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
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1 - Show Employees");
                Console.WriteLine("2 - Show Departments");
                Console.WriteLine("3 - Employees in IT Department");
                Console.WriteLine("4 - Employees in Finance Department");
                Console.WriteLine("5 - Employees in HR Department");
                Console.WriteLine("6 - Employees with Salary > 40000");
                Console.WriteLine("7 - Employees with Salary <= 40000");
                Console.WriteLine("8 - All Employees with Department Names");
                Console.WriteLine("9 - Exit");

                Console.Write("\nEnter a number: ");
                string userChoice = Console.ReadLine();

                if (userChoice == "1")
                {
                    Console.WriteLine("\n---- Employees ----");
                    foreach (var emp in employees)
                    {
                        Console.WriteLine($"{emp.FirstName} {emp.LastName,-20} - Salary: {emp.AnnualSalary}");
                    }
                }
                else if (userChoice == "2")
                {
                    Console.WriteLine("\n---- Departments ----");
                    Console.WriteLine($"{"Id",-10} {"Short",-10} {"Long"}");
                    foreach (var dep in departments)
                    {
                        Console.WriteLine($"{dep.Id,-10} {dep.ShortName,-10} {dep.LongName}");
                    }
                }
                else if (userChoice == "3")
                {
                    Console.WriteLine("\n---- Employees in IT ----");
                    var query = from emp in employees
                                join dep in departments on emp.DepartmentId equals dep.Id
                                where dep.ShortName == "IT"
                                select emp;

                    foreach (var emp in query)
                    {
                        Console.WriteLine($"{emp.FirstName} {emp.LastName} - {emp.AnnualSalary}");
                    }
                }
                else if (userChoice == "4")
                {
                    Console.WriteLine("\n---- Employees in Finance ----");
                    var query = from emp in employees
                                join dep in departments on emp.DepartmentId equals dep.Id
                                where dep.ShortName == "FN"
                                select emp;

                    foreach (var emp in query)
                    {
                        Console.WriteLine($"{emp.FirstName} {emp.LastName} - {emp.AnnualSalary}");
                    }
                }
                else if (userChoice == "5")
                {
                    Console.WriteLine("\n---- Employees in HR ----");
                    var query = from emp in employees
                                join dep in departments on emp.DepartmentId equals dep.Id
                                where dep.ShortName == "HR"
                                select emp;

                    foreach (var emp in query)
                    {
                        Console.WriteLine($"{emp.FirstName} {emp.LastName} - {emp.AnnualSalary}");
                    }
                }
                else if (userChoice == "6")
                {
                    Console.WriteLine("\n---- Employees with Salary > 40000 ----");
                    var query = from emp in employees
                                where emp.AnnualSalary > 40000
                                select emp;

                    foreach (var emp in query)
                    {
                        Console.WriteLine($"{emp.FirstName} {emp.LastName} - {emp.AnnualSalary}");
                    }
                }
                else if (userChoice == "7")
                {
                    Console.WriteLine("\n---- Employees with Salary <= 40000 ----");
                    var query = from emp in employees
                                where emp.AnnualSalary <= 40000
                                select emp;

                    foreach (var emp in query)
                    {
                        Console.WriteLine($"{emp.FirstName} {emp.LastName} - {emp.AnnualSalary}");
                    }
                }
                else if (userChoice == "8")
                {
                    Console.WriteLine("\n---- All Employees with Department Names ----");
                    var query = from emp in employees
                                join dep in departments on emp.DepartmentId equals dep.Id
                                select new
                                {
                                    Name = emp.FirstName + " " + emp.LastName,
                                    Department = dep.LongName,
                                    Salary = emp.AnnualSalary
                                };

                    foreach (var item in query)
                    {
                        Console.WriteLine($"{item.Name,-20} | {item.Department,-25} | Salary: {item.Salary}");
                    }
                }
                else if (userChoice == "9")
                {
                    Console.WriteLine("\nOk, Goodbye!");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice, please try again.");
                    continue;
                }


                Console.Write("\nDo you want to do something else? (y/n): ");
                string again = Console.ReadLine().Trim().ToLower();

                if (again == "y")
                {
                    keepRunning = true;

                }
                else if (again == "n")
                {
                    keepRunning = false;
                    Console.WriteLine("\nOk, Goodbye!");
                }
                else { 
                    keepRunning = true;
                    Console.WriteLine("Invalid choice");
                }
            }
        }
    }
}
