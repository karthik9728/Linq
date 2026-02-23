using Linq.Utils;
using System.Data;

namespace LinqToDataset
{
    /// <summary>
    /// <list type="number">
    /// <item>Used for: ADO.NET</item>
    /// <item>Works with: DataSet, DataTable, DataRow</item>
    /// <item>Example use cases: querying legacy datasets</item>
    /// </list>
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            var employeesTable  = DataProvider.CreateEmployeeTable();

            //Convert DataTable → Enumerable (IMPORTANT)
            var employees = employeesTable.AsEnumerable();

            var olderEmployees = employees.Where(e => e.Field<int>("Age") > 25);

            foreach (var emp in olderEmployees)
            {
                Console.WriteLine(emp.Field<string>("Name"));
            }

            Console.WriteLine("----------Projection--------------");
            var employeeSummary = employees
                                .Select(e => new
                                {
                                    Name = e.Field<string>("Name"),
                                    Department = e.Field<string>("Department"),
                                    Salary = e.Field<decimal>("Salary")
                                });

            foreach (var emp in employeeSummary)
            {
                Console.WriteLine($"{emp.Name} - {emp.Department} - {emp.Salary}");
            }

            Console.WriteLine("----------Sorting--------------");

            var sortedBySalary = employees.OrderByDescending(e => e.Field<decimal>("Salary"));

            foreach (var emp in sortedBySalary)
            {
                Console.WriteLine($"{emp.Field<string>("Name")} - {emp.Field<decimal>("Salary")}");
            }

            Console.WriteLine("----------Grouping--------------");
            var groupedByDept = employees.GroupBy(e => e.Field<string>("Department"));

            foreach (var group in groupedByDept)
            {
                Console.WriteLine($"Department: {group.Key}");

                foreach (var emp in group)
                {
                    Console.WriteLine($"  {emp.Field<string>("Name")}");
                }
            }

            Console.WriteLine("----------Aggregation--------------");
            var avgSalaryByDept = employees
                                .GroupBy(e => e.Field<string>("Department"))
                                .Select(g => new
                                {
                                    Department = g.Key,
                                    AverageSalary = g.Average(e => e.Field<decimal>("Salary"))
                                });

            foreach (var item in avgSalaryByDept)
            {
                Console.WriteLine($"{item.Department} - Avg Salary: {item.AverageSalary}");
            }
        }
    }
}