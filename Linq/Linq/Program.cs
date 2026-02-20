namespace Linq
{
    /// <summary>
    /// LINQ (Language Integrated Query) is a declarative querying capability in C# that allows you to query, filter, transform, and aggregate data from different data sources (objects, databases, XML, JSON, etc.) using a consistent, type-safe syntax integrated into the language.
    /// <list type="number">
    /// <item>Imperative means: You tell the computer step-by-step instructions.</item>
    /// <item>Declarative means: You describe the result, not the steps.</item>
    /// </list>
    /// Traditional loops tell the system how to iterate and process data. LINQ abstracts iteration and lets us focus on what data we want, making code more readable, reusable, and expressive.
    /// Linq works on IEnumerable or IQueryable
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };


            // How to do it
            // Full control(Index-based, Imperative)
            Console.WriteLine(".Net For Loop");
            for (int i = 0; i < numbers.Count(); i++)
            {
                if (numbers[i] < 70)
                {
                    Console.Write(numbers[i] + ",");
                }
            }

            //loop – Safer iteration(Imperative)
            Console.WriteLine("\n------------------------");
            Console.WriteLine(".Net ForEach Loop");
            foreach (var number in numbers)
            {
                if (number < 70)
                {
                    Console.Write(number + ",");
                }
            }

            // Controlled for loop – Explicit iteration logic
            Console.WriteLine("\n------------------------");
            Console.WriteLine(".Net Controlled For Loop");
            for (int i = 0; i < numbers.Count(); i += 2)
            {
                if (numbers[i] < 70)
                {
                    Console.Write(numbers[i] + ",");
                }
            }

            // What you want (Declarative)
            Console.WriteLine("\n------------------------");
            Console.WriteLine("Using Linq Query");

            // This does not execute immediately
            var query = from n in numbers  // Data Source
                        where n < 70       // Filter
                        select n;          // Select

            var numbersCount = (from n in numbers where n < 70 select n).Count();
            Console.WriteLine($"Numbers Count:{numbersCount}");

            foreach (var number in query)
                Console.Write(number + ",");

            Console.WriteLine("\n------------------------");
            Console.WriteLine("Using Linq Method");

            //var queryMethod = numbers.Where(CheckNumber).Select(x => x);
            //var queryMethod = numbers.Where(n => n < 70).Select(x => x);
            var queryMethod = numbers.Where(n => n < 70);

            foreach (var number in queryMethod)
                Console.Write(number + ",");
        }

        static bool CheckNumber(int number)
        {
            return number < 70;
        }
    }
}