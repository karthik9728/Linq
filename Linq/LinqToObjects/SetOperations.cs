using Linq.Utils;
using Linq.Utils.Models;

namespace LinqToObjects
{
    /// <summary>
    /// <seealso href="https://learn.microsoft.com/en-us/dotnet/csharp/linq/standard-query-operators/set-operations">Set operations (C#)</seealso>
    /// </summary>
    public class SetOperations
    {
        // Get Data
        private static List<int> Numbers = DataProvider.GetNumbers();
        private static List<Employee> Employees = DataProvider.GetEmployees();

        private static List<Event> SpringCodingEventMembers = DataProvider.GetSpringCodingEvent();
        private static List<Event> WinterSecurityEventMembers = DataProvider.GetWinterSecurityEvent();

        /// <summary>
        /// Removes duplicate values from a collection.
        /// </summary>
        public static void DistinctOperator()
        {
            Console.WriteLine("----------Numbers List----------");
            foreach (var n in Numbers)
            {
                Console.Write(n + "|");
            }

            // Query Syntax
            Console.WriteLine("\n----------Query Syntax----------");
            var numbersLinqQuery = (from n in Numbers select n).Distinct();

            foreach (var n in numbersLinqQuery)
            {
                Console.Write(n + "|");
            }

            Console.WriteLine();

            // Each object instance is unique in memory, so Distinct() treats objects 
            // with the same values as different unless equality is properly overridden.

            //var linqQuery = (from employee in Employees select employee).Distinct();

            //foreach (var employee in linqQuery)
            //{
            //    Console.WriteLine($"Id:{employee.Id},Name:{employee.Name}");
            //}


            // Method Syntax
            Console.WriteLine("\n---------Method Syntax----------");
            var numbersLinqMethod = Numbers.Distinct().Select(x => x);

            foreach (var n in numbersLinqMethod)
            {
                Console.Write(n + "|");
            }
        }

        /// <summary>
        /// Removes duplicate values from a collection.
        /// </summary>
        public static void DistinctByOperator()
        {
            Console.WriteLine("\n----------------------------------------------");
            Console.WriteLine($"Original Employees Count:{Employees.Count()}");

            // Query Syntax
            Console.WriteLine("----------Query Syntax----------");

            var linqQuery = (from employee in Employees select employee).DistinctBy(x => x.Id);

            Console.WriteLine($"Employees Count:{linqQuery.Count()}");

            foreach (var employee in linqQuery)
            {
                Console.WriteLine($"Id:{employee.Id},Name:{employee.Name}");
            }


            // Method Syntax
            Console.WriteLine("---------Method Syntax----------");

            var linqMethod = Employees.DistinctBy(x => x.Id).Select(x => x);

            Console.WriteLine($"Employees Count:{linqMethod.Count()}");

            foreach (var employee in linqMethod)
            {
                Console.WriteLine($"Id:{employee.Id},Name:{employee.Name}");
            }
        }
    }
}
