using Linq.Utils;
using Linq.Utils.Models;

namespace LinqToObjects
{
    public class Grouping
    {
        private static List<Fruit> Fruits = DataProvider.GetFruits();
        private static List<Color> Colors = DataProvider.GetColors();

        public static void LinqGroupBy()
        {
            // Query Syntax
            Console.WriteLine("----------Query Syntax (GroupBy)----------");

            var linqQuery = from f in Fruits
                        group f by f.ColorId into fruitGroup
                        select new
                        {
                            ColorId = fruitGroup.Key,
                            Fruits = fruitGroup.Select(f => f.Name)
                        };

            foreach (var g in linqQuery)
            {
                var colorName = Colors.FirstOrDefault(c => c.Id == g.ColorId)?.Name ?? "No Color";
                Console.WriteLine($"Color: {colorName}, Fruits: {string.Join(", ", g.Fruits)}");
            }

            // Method Syntax
            Console.WriteLine("---------Method Syntax (GroupBy)----------");

            var linqMethod = Fruits.GroupBy(f => f.ColorId)
                               .Select(g => new
                               {
                                   ColorId = g.Key,
                                   Fruits = g.Select(f => f.Name)
                               });

            foreach (var g in linqMethod)
            {
                var colorName = Colors.FirstOrDefault(c => c.Id == g.ColorId)?.Name ?? "No Color";
                Console.WriteLine($"Color: {colorName}, Fruits: {string.Join(", ", g.Fruits)}");
            }
        }

        public static void LinqToLookup()
        {
            // Query Syntax
            Console.WriteLine("----------Query Syntax (ToLookup)----------");

            var linqQuery = (from f in Fruits
                               group f by f.ColorId).ToLookup(g => g.Key, g => g.Select(f => f.Name));

            foreach (var kvp in linqQuery)
            {
                var colorName = Colors.FirstOrDefault(c => c.Id == kvp.Key)?.Name ?? "No Color";
                var fruits = kvp.SelectMany(x => x);
                Console.WriteLine($"Color: {colorName}, Fruits: {string.Join(", ", fruits)}");
            }

            // Method Syntax
            Console.WriteLine("---------Method Syntax (ToLookup)----------");

            var linqMethod = Fruits.ToLookup(f => f.ColorId, f => f.Name);

            foreach (var kvp in linqMethod)
            {
                var colorName = Colors.FirstOrDefault(c => c.Id == kvp.Key)?.Name ?? "No Color";
                Console.WriteLine($"Color: {colorName}, Fruits: {string.Join(", ", kvp)}");
            }
        }
    }
}
