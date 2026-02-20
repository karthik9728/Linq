using Linq.Utils;
using Linq.Utils.Common;
using Linq.Utils.Models;

namespace LinqToObjects
{
    /// <summary>
    /// <seealso href="https://learn.microsoft.com/en-us/dotnet/csharp/linq/standard-query-operators/projection-operations">Projection operations (C#)</seealso>
    /// </summary>
    public static class ProjectionOperations
    {
        // Get Data
        private static List<Employee> Employees = DataProvider.GetEmployees();

        /// <summary>
        /// Projects values that are based on a transform function.
        /// </summary>
        public static void SelectOperator()
        {
            // Query Syntax
            Console.WriteLine("----------Query Syntax----------");
            //var linqQuery = from employee in Employees
            //                where employee.Team == Team.DevOps
            //                select (employee.Id, employee.Name);

            //anonymous type
            var linqQuery = from employee in Employees
                            where employee.Team == Team.DevOps
                            select new
                            {
                                Id = employee.Id,
                                Name = employee.Name,
                            };

            foreach (var employee in linqQuery)
            {
                Console.WriteLine($"Id:{employee.Id},Name:{employee.Name}");
            }

            // Method Syntax
            Console.WriteLine("---------Method Syntax----------");
            var linqMethod = Employees.Where(x => x.Team == Team.DevOps)
                                      .Select(employee => new
                                      {
                                          Id = employee.Id,
                                          Name = employee.Name
                                      });

            foreach (var employee in linqMethod)
            {
                Console.WriteLine($"Id:{employee.Id},Name:{employee.Name}");
            }
        }

        /// <summary>
        /// Projects sequences of values that are based on a transform function and then flattens them into one sequence.
        /// </summary>
        public static void SelectManyOperator()
        {
            // Query Syntax
            Console.WriteLine("----------Query Syntax----------");
            //var linqQuery = from employee in Employees
            //                where employee.Team == Team.DevOps
            //                select (employee.Id, employee.Name);

            //anonymous type
            var linqQuery = from employee in Employees
                            where employee.Team == Team.ResearchAndDevelopment
                            from e in employee.Name.ToArray()
                            select e;

            foreach (var x in linqQuery)
            {
                Console.Write($"{x}");
            }

            // Method Syntax
            Console.WriteLine("\n---------Method Syntax----------");
            var linqMethod = Employees.Where(x => x.Team == Team.ResearchAndDevelopment)
                                      .SelectMany(employee => employee.Name.ToArray());

            foreach (var x in linqMethod)
            {
                Console.Write($"{x}");
            }
        }

        /// <summary>
        /// Combines two sequences into one sequence of combined elements.
        /// </summary>
        public static void ZipOperator()
        {
            var topEmployees = Employees.Take(5);

            var salaries = new List<decimal> { 5000, 6000, 5500, 7000, 6500 };

            // Methods Syntax (Zip is method syntax)
            Console.WriteLine("---------Zip Operator----------");
            var employeeWithSalary = topEmployees.Zip(salaries, (emp, sal) => new
                                    {
                                        Name = emp.Name,
                                        Team = emp.Team,
                                        Salary = sal
                                    });

            foreach (var item in employeeWithSalary)
            {
                Console.WriteLine($"Name: {item.Name}, Team: {item.Team}, Salary: {item.Salary}");
            }
        }
    }
}
