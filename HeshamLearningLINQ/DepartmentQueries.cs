using System;
using System.Collections.Generic;

namespace HeshamLearningLINQ
{
    public static class DepartmentQueries
    {
        public static void ShowDepartments(List<Department> departments)
        {
            Console.WriteLine("\n---- Departments ----");
            Console.WriteLine($"{"Id",-10} {"Short",-10} {"Long"}");

            foreach (var dep in departments)
            {
                Console.WriteLine($"{dep.Id,-10} {dep.ShortName,-10} {dep.LongName}");
            }
        }
    }
}
