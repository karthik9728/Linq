using Linq.Utils;
using Linq.Utils.Models;

namespace LinqToObjects
{
    /// <summary>
    /// <list type="number">
    /// <item>All(): checks all items satisfy condition.</item>
    /// <item>Any(): checks if at least one item satisfies condition.</item>
    /// <item>Contains(): checks if a specific value exists in a collection.</item>
    /// </list>
    /// <seealso href="https://learn.microsoft.com/en-us/dotnet/csharp/linq/standard-query-operators/quantifier-operations">Quantifier operations in LINQ (C#)</seealso>
    /// </summary>
    public class QuantifierOperations
    {
        private static List<Product> Products = DataProvider.GetProducts();

        public static void LinqAll()
        {
            // Query Syntax
            Console.WriteLine("----------Query Syntax----------");
            var linqQuery = (from p in Products select p).All(x => x.Stock > 0);

            Console.WriteLine($"{(linqQuery ? "All products are in stock" : "Some products are out of stock")}");

            // Method Syntax
            Console.WriteLine("---------Method Syntax----------");
            var linqMethod = Products.All(x => x.Stock > 0);

            Console.WriteLine($"{(linqMethod ? "All products are in stock" : "Some products are out of stock")}");
        }


        public static void LinqAny()
        {
            // Query Syntax
            Console.WriteLine("----------Query Syntax----------");
            var linqQuery = (from p in Products select p).Any(x => x.Name == "Laptop");

            Console.WriteLine($"{(linqQuery ? "Laptop Exists" : "Laptop Does Not Exists")}");

            // Method Syntax
            Console.WriteLine("---------Method Syntax----------");
            var linqMethod = Products.Any(x => x.Name == "Playstation");

            Console.WriteLine($"{(linqMethod ? "Playstation Exists" : "Playstation Does Not Exists")}");
        }

        public static void LinqContains()
        {
            var Categories = Products.DistinctBy(x => x.Category).Select(p => p.Category).ToList();

            // Query Syntax
            Console.WriteLine("----------Query Syntax----------");
            var linqQuery = (from c in Categories select c).Contains("Electronics");

            Console.WriteLine($"{(linqQuery ? "Exists" : "Does Not Exists")}");

            // Method Syntax
            Console.WriteLine("---------Method Syntax----------");
            var linqMethod = Categories.Contains("Cloths");

            Console.WriteLine($"{(linqMethod ? "Exists" : "Does Not Exists")}");
        }
    }
}
