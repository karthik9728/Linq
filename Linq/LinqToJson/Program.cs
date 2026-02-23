using Newtonsoft.Json.Linq;

namespace LinqToJson
{
    class Program
    {
        public static void Main(string[] args)
        {
            string json = File.ReadAllText("ProductCatalog.json");

            JObject root = JObject.Parse(json);

            JArray products = (JArray)root["catalog"];

            foreach (var product in products)
            {
                Console.WriteLine(product["name"]);
            }

            Console.WriteLine("----------Filter Data--------------");

            var inStockProducts = products.Where(p => (bool)p["inStock"]);

            foreach (var p in inStockProducts)
            {
                Console.WriteLine(p["name"]);
            }

            Console.WriteLine("----------Projection--------------");
            var productSummary = products
                                .Select(p => new
                                {
                                    Id = (string)p["id"],
                                    Name = (string)p["name"],
                                    Price = (decimal)p["price"]
                                });

            foreach (var p in productSummary)
            {
                Console.WriteLine($"{p.Id} - {p.Name} - {p.Price}");
            }

            Console.WriteLine("----------Sorting--------------");
            var sortedByPrice = products.OrderBy(p => (decimal)p["price"]);

            foreach (var p in sortedByPrice)
            {
                Console.WriteLine($"{p["name"]} - {p["price"]}");
            }

            Console.WriteLine("----------Grouping--------------");
            var groupedByCategory = products.GroupBy(p => (string)p["category"]);

            foreach (var group in groupedByCategory)
            {
                Console.WriteLine($"Category: {group.Key}");

                foreach (var p in group)
                {
                    Console.WriteLine($"  {p["name"]}");
                }
            }

            Console.WriteLine("----------Aggregation--------------");
            var avgPriceByCategory = products
                                    .GroupBy(p => (string)p["category"])
                                    .Select(g => new
                                    {
                                        Category = g.Key,
                                        AvgPrice = g.Average(p => (decimal)p["price"])
                                    });

            foreach (var item in avgPriceByCategory)
            {
                Console.WriteLine($"{item.Category} - Avg Price: {item.AvgPrice}");
            }

            Console.WriteLine("----------Transform JSON--------------");
            JArray availableProducts =new JArray(
                                            products
                                                .Where(p => (bool)p["inStock"])
                                                .Select(p => new JObject
                                                {
                                                    ["code"] = p["id"],
                                                    ["title"] = p["name"],
                                                    ["cost"] = p["price"]
                                                })
                                        );

            JObject output = new JObject
            {
                ["availableProducts"] = availableProducts
            };

            Console.WriteLine(output.ToString());
        }
    }
}