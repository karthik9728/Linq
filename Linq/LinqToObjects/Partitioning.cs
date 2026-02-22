using Linq.Utils;

namespace LinqToObjects
{
    /// <summary>
    /// <seealso href="https://learn.microsoft.com/en-us/dotnet/csharp/linq/standard-query-operators/partitioning-data">Partitioning data (C#)</seealso>
    /// </summary>
    public class Partitioning
    {
        private static string[] OfficeSupplies = DataProvider.OfficeSupplies;
        private static List<int> Numbers = DataProvider.Numbers;

        public static void LinqSkip()
        {
            Console.WriteLine("----------Office Supplies List----------");

            foreach (string x in OfficeSupplies)
            {
                Console.Write(x + "|");
            }

            // Method Syntax
            Console.WriteLine("\n---------Method Syntax----------");
            var linqMethod = OfficeSupplies.Skip(4);

            foreach (string x in linqMethod)
            {
                Console.Write(x + "|");
            }
        }

        public static void LinqTake()
        {
            Console.WriteLine("\n----------Office Supplies List----------");

            foreach (string x in OfficeSupplies)
            {
                Console.Write(x + "|");
            }

            // Method Syntax
            Console.WriteLine("\n---------Method Syntax----------");
            var linqMethod = OfficeSupplies.Take(4);

            foreach (string x in linqMethod)
            {
                Console.Write(x + "|");
            }
        }

        public static void LinqSkipAndTake()
        {
            Console.WriteLine("\n----------Office Supplies List----------");

            foreach (string x in OfficeSupplies)
            {
                Console.Write(x + "|");
            }

            // Method Syntax
            Console.WriteLine("\n---------Method Syntax----------");
            var linqMethod = OfficeSupplies.Skip(2).Take(3);

            foreach (string x in linqMethod)
            {
                Console.Write(x + "|");
            }
        }

        public static void LinqSkipWhile()
        {
            Console.WriteLine("----------Numbers List----------");
            foreach (var n in Numbers)
            {
                Console.Write(n + "|");
            }

            // Method Syntax
            Console.WriteLine("\n---------Method Syntax----------");
            var linqMethod = Numbers.SkipWhile(x => x < 5);

            foreach (int x in linqMethod)
            {
                Console.Write(x + "|");
            }
        }

        public static void LinqTakeWhile()
        {
            Console.WriteLine("\n----------Numbers List----------");
            foreach (var n in Numbers)
            {
                Console.Write(n + "|");
            }

            // Method Syntax
            Console.WriteLine("\n---------Method Syntax----------");
            var linqMethod = Numbers.TakeWhile(x => x < 15);

            foreach (int x in linqMethod)
            {
                Console.Write(x + "|");
            }
        }

        public static void LinqChunk()
        {
            Console.WriteLine("\n----------Numbers List----------");
            foreach (var n in Numbers)
            {
                Console.Write(n + "|");
            }

            // Method Syntax
            Console.WriteLine("\n---------Method Syntax----------");
            var linqMethod = Numbers.Chunk(4);

            foreach (int[] chunk in linqMethod)
            {
                foreach (int x in chunk)
                {
                    Console.Write(x + "|");
                }
                Console.WriteLine();
            }
        }
    }
}
