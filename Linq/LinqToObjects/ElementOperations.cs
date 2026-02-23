using Linq.Utils;
using Linq.Utils.Models;

namespace LinqToObjects
{
    /// <summary>
    /// Element Operations
    /// </summary>
    public class ElementOperations
    {
        // Get Data
        private static List<Employee> Employees = DataProvider.GetEmployees();

        public static void LinqFirst()
        {        
            var linqQuery = (from employee in Employees where employee.Name == "Hannah Wilson" select employee);

            Console.WriteLine("----------Where Filter----------");
            foreach (var employee in linqQuery)
            {
                Console.WriteLine($"Id:{employee.Id}, Name:{employee.Name}, Team:{employee.Team}");
            }

            // Query Syntax
            Console.WriteLine("----------Query Syntax----------");
            //var linqQueryEmployee = (from employee in Employees select employee).First();
            var linqQueryEmployee = (from employee in Employees select employee).First(x => x.Name == "Hannah Wilson");

            Console.WriteLine($"Id:{linqQueryEmployee.Id}, Name:{linqQueryEmployee.Name}, Team:{linqQueryEmployee.Team}");


            // Method Syntax
            Console.WriteLine("---------Method Syntax----------");
            var linqMethod = Employees.First(x => x.Name == "Hannah Wilson");
            Console.WriteLine($"Id:{linqMethod.Id}, Name:{linqMethod.Name}, Team:{linqMethod.Team}");

            //var linqMethod = Employees.FirstOrDefault(x => x.Name == "Hannah Wilsons");
            //Console.WriteLine($"Id:{linqMethod?.Id.ToString() ?? "N/A"}, Name:{linqMethod?.Name ?? "N/A"}, Team:{linqMethod?.Team.ToString() ?? "N/A"}");
        }

        public static void LinqLast()
        {

            var linqQuery = (from employee in Employees where employee.Name == "Hannah Wilson" select employee);

            Console.WriteLine("----------Where Filter----------");
            foreach (var employee in linqQuery)
            {
                Console.WriteLine($"Id:{employee.Id}, Name:{employee.Name}, Team:{employee.Team}");
            }

            // Query Syntax
            Console.WriteLine("----------Query Syntax----------");
            var linqQueryEmployee = (from employee in Employees select employee).Last(x => x.Name == "Hannah Wilson");

            Console.WriteLine($"Id:{linqQueryEmployee.Id}, Name:{linqQueryEmployee.Name}, Team:{linqQueryEmployee.Team}");


            // Method Syntax
            Console.WriteLine("---------Method Syntax----------");
            var linqMethod = Employees.Last(x => x.Name == "Hannah Wilson");
            Console.WriteLine($"Id:{linqMethod.Id}, Name:{linqMethod.Name}, Team:{linqMethod.Team}");

            //var linqMethod = Employees.LastOrDefault(x => x.Name == "Hannah Wilsons");
            //Console.WriteLine($"Id:{linqMethod?.Id.ToString() ?? "N/A"}, Name:{linqMethod?.Name ?? "N/A"}, Team:{linqMethod?.Team.ToString() ?? "N/A"}");
        }

        public static void LinqSingle()
        {
            //var linqQuery = (from employee in Employees select employee).First();
            var linqQuery = (from employee in Employees where employee.Id == 8 select employee);

            Console.WriteLine("----------Where Filter----------");
            foreach (var employee in linqQuery)
            {
                Console.WriteLine($"Id:{employee.Id}, Name:{employee.Name}, Team:{employee.Team}");
            }


            // Query Syntax
            Console.WriteLine("----------Query Syntax----------");
            //var linqQueryEmployee = (from employee in Employees select employee).Single(x => x.Id == 8);
            var linqQueryEmployee = (from employee in Employees select employee).Single(x => x.Id == 7);

            Console.WriteLine($"Id:{linqQueryEmployee.Id}, Name:{linqQueryEmployee.Name}, Team:{linqQueryEmployee.Team}");


            // Method Syntax
            Console.WriteLine("---------Method Syntax----------");
            //var linqMethod = Employees.Single(x => x.Id == 8);
            var linqMethod = Employees.Single(x => x.Id == 7);
            Console.WriteLine($"Id:{linqMethod.Id}, Name:{linqMethod.Name}, Team:{linqMethod.Team}");

            //var linqMethod = Employees.SingleOrDefault(x => x.Id == 100);
            //Console.WriteLine($"Id:{linqMethod?.Id.ToString() ?? "N/A"}, Name:{linqMethod?.Name ?? "N/A"}, Team:{linqMethod?.Team.ToString() ?? "N/A"}");
        }
    }
}
