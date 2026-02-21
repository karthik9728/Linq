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
        private static List<int> Numbers = DataProvider.Numbers;
        private static string[] Box1 = DataProvider.Box1;
        private static string[] Box2 = DataProvider.Box2;
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

        /// <summary>
        /// The returned sequence contains only the elements from the first input sequence that aren't in the second input sequence.
        /// </summary>
        public static void ExceptOperator()
        {
            Console.WriteLine("Box 1 Items");
            foreach (var item in Box1)
            {
                Console.Write(item + "|");
            }


            Console.WriteLine("\nBox 2 Items");
            foreach (var item in Box2)
            {
                Console.Write(item + "|");
            }

            // Query Syntax
            Console.WriteLine("\n----------Query Syntax----------");
            var linqQuery = from item in Box1.Except(Box2) select item;

            foreach (var item in linqQuery)
            {
                Console.WriteLine(item);
            }


            // Method Syntax
            Console.WriteLine("---------Method Syntax----------");
            var linqMethod = Box1.Except(Box2).Select(item => item);

            foreach (var item in linqMethod)
            {
                Console.WriteLine(item);
            }
        }

        /// <summary>
        /// The returned sequence contains only the elements from the first input sequence that aren't in the second input sequence.
        /// </summary>
        public static void ExceptByOperator()
        {
            // Flatten nested collections
            var springEmployees = SpringCodingEventMembers.SelectMany(e => e.Employees);
            var winterEmployees = WinterSecurityEventMembers.SelectMany(e => e.Employees);


            //"Give me Spring employees whose Id does NOT exist in Winter."
            Console.WriteLine("----------Full Employee List----------");

            foreach (var emp in springEmployees.Concat(winterEmployees))
            {
                Console.Write($"{emp.Name}({emp.Id})" + "|");
            }

            // Query Syntax
            Console.WriteLine("\n----------Query Syntax----------");
            var linqQuery = from emp in springEmployees.ExceptBy(winterEmployees.Select(we => we.Id), sp => sp.Id) select emp;

            foreach (var emp in linqQuery)
            {

                Console.Write($"{emp.Name}({emp.Id})" + "|");
            }


            // Method Syntax
            Console.WriteLine("\n---------Method Syntax----------");
            //var linqMethod = springEmployees.ExceptBy(winterEmployees.Select(we => we.Id), sp => sp.Id).Select(emp => emp);
            var linqMethod = springEmployees.ExceptBy(winterEmployees.Select(we => we.Id), sp => sp.Id);

            foreach (var emp in linqMethod)
            {

                Console.Write($"{emp.Name}({emp.Id})" + "|");
            }

        }

        /// <summary>
        /// Returns the set intersection, which means elements that appear in each of two collections.
        /// The returned sequence contains the elements that are common to both of the input sequences.
        /// </summary>
        public static void IntersectOperator()
        {
            Console.WriteLine("Box 1 Items");
            foreach (var item in Box1)
            {
                Console.Write(item + "|");
            }


            Console.WriteLine("\nBox 2 Items");
            foreach (var item in Box2)
            {
                Console.Write(item + "|");
            }

            // Query Syntax
            Console.WriteLine("\n----------Query Syntax----------");
            var linqQuery = from item in Box1.Intersect(Box2) select item;

            foreach (var item in linqQuery)
            {
                Console.WriteLine(item);
            }


            // Method Syntax
            Console.WriteLine("---------Method Syntax----------");
            var linqMethod = Box1.Intersect(Box2).Select(item => item);

            foreach (var item in linqMethod)
            {
                Console.WriteLine(item);
            }
        }

        /// <summary>
        /// The returned sequence contains the elements that are common to both of the input sequences.
        /// </summary>
        public static void IntersectByOperator()
        {
            // Flatten nested collections
            var springEmployees = SpringCodingEventMembers.SelectMany(e => e.Employees);
            var winterEmployees = WinterSecurityEventMembers.SelectMany(e => e.Employees);


            //"Give me Spring employees whose Id does NOT exist in Winter."
            Console.WriteLine("----------Full Employee List----------");

            foreach (var emp in springEmployees.Concat(winterEmployees))
            {
                Console.Write($"{emp.Name}({emp.Id})" + "|");
            }

            // Query Syntax
            Console.WriteLine("\n----------Query Syntax----------");
            var linqQuery = from emp in springEmployees.IntersectBy(winterEmployees.Select(we => we.Id), sp => sp.Id) select emp;

            foreach (var emp in linqQuery)
            {

                Console.Write($"{emp.Name}({emp.Id})" + "|");
            }


            // Method Syntax
            Console.WriteLine("\n---------Method Syntax----------");
            //var linqMethod = springEmployees.IntersectBy(winterEmployees.Select(we => we.Id), sp => sp.Id).Select(emp => emp);
            var linqMethod = springEmployees.IntersectBy(winterEmployees.Select(we => we.Id), sp => sp.Id);

            foreach (var emp in linqMethod)
            {

                Console.Write($"{emp.Name}({emp.Id})" + "|");
            }

        }
    }
}
