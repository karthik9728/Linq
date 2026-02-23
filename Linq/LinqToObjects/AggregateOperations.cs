using Linq.Utils;

namespace LinqToObjects
{
    public class AggregateOperations
    {
        private static List<int> Numbers = DataProvider.Numbers;

        public static void LinqAggregateOperations()
        {
            Console.WriteLine("----------Method Syntax----------");

            var min = Numbers.Min();
            Console.WriteLine($"Min:{min}");

            var max = Numbers.Max();
            Console.WriteLine($"Max:{max}");

            var count = Numbers.Count();
            Console.WriteLine($"No of Numbers:{count}");

            var sum = Numbers.Sum();
            Console.WriteLine($"Total:{sum}");

            var avg = Numbers.Average();
            Console.WriteLine($"Average:{avg}");

            Console.WriteLine("----------Sequence----------");
            foreach (var x in Enumerable.Sequence(1, 20, 2))
            {
                Console.Write(x + "|");
            }
        }
    }
}
