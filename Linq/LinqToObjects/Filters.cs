using Linq.Utils;
using Linq.Utils.Models;

namespace LinqToObjects
{
    /// <summary>
    /// <seealso href="https://learn.microsoft.com/en-us/dotnet/csharp/linq/standard-query-operators/filtering-data">Filtering Data in C# with LINQ</seealso>
    /// </summary>
    public static class Filters
    {
        // Get Data
        private static List<Employee> employees = DataProvider.GetEmployees();

        public static void LinqWhere()
        {
            // Query Syntax
            Console.WriteLine("----------Query Syntax----------");
            IEnumerable<Employee> linqQuery = from employee in employees where employee.Name.Equals("Bob Smith") select employee;

            foreach (var employee in linqQuery)
            {
                Console.WriteLine($"Name:{employee.Name}, Team:{employee.Team}");
            }

            // Method Syntax
            Console.WriteLine("---------Method Syntax----------");
            //IEnumerable<Employee> linqMethod = employees.Where(x => x.Name.Equals("Diana Prince"));
            //IEnumerable<Employee> linqMethod = employees.Where(x => x.Name.Equals("Diana Prince")).Select(employee => employee);

            //IEnumerable<Employee> linqMethod = employees.Where(x => x.Name == "Diana Prince");
            IEnumerable<Employee> linqMethod = employees.Where(x => x.Name == "Diana Prince").Select(employee => employee);

            foreach (var employee in linqMethod)
            {
                Console.WriteLine($"Name:{employee.Name}, Team:{employee.Team}");
            }
        }

        public static void LinqOfType()
        {
            IEnumerable<Manager> managers = employees.OfType<Manager>();

            Console.WriteLine("----------Managers List---------");

            foreach (var employee in managers)
            {
                Console.WriteLine($"Name:{employee.Name}, Team:{employee.Team}");
            }

            IEnumerable<SecurityEngineer> securityEngineer = employees.OfType<SecurityEngineer>();

            Console.WriteLine("----------Security Engineers List---------");

            foreach (var employee in securityEngineer)
            {
                Console.WriteLine($"Name:{employee.Name}, Team:{employee.SecurityTeam}");
            }
        }
    }
}
