
using System.Diagnostics.Metrics;
using System.Reflection.Metadata;
using System.Xml.Linq;

namespace LinqToXML
{

    public class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            #region
            //Build Action      → Content
            //Copy to Output    → Copy if newer
            #endregion

            XDocument doc = XDocument.Load("ProductCatalog.xml");

            var products = doc.Descendants("Product");

            Console.WriteLine("----------Read Data from XML--------------");
            foreach (var product in products)
            {
                Console.WriteLine(product.Element("Name")?.Value);
            }

            Console.WriteLine("----------Filter Data--------------");
            var electronicsInStock = products
                                    .Where(p =>(string)p.Element("Category") == "Electronics" && (bool)p.Element("InStock") == true);

            foreach (var p in electronicsInStock)
            {
                Console.WriteLine(p.Element("Name")?.Value);
            }

            Console.WriteLine("----------Projection--------------");
            var productSummary = products
                                .Select(p => new
                                {
                                    Id = (string)p.Attribute("id"),
                                    Name = (string)p.Element("Name"),
                                    Price = (decimal)p.Element("Price")
                                });

            foreach (var p in productSummary)
            {
                Console.WriteLine($"{p.Id} - {p.Name} - {p.Price}");
            }

            Console.WriteLine("----------Sorting--------------");
            var sortedByPrice = products.OrderByDescending(p => (decimal)p.Element("Price"));

            foreach (var p in sortedByPrice)
            {
                Console.WriteLine($"{p.Element("Name")?.Value} - {p.Element("Price")?.Value}");
            }

            Console.WriteLine("----------Grouping--------------");
            var groupedByCategory = products.GroupBy(p => (string)p.Element("Category"));

            foreach (var group in groupedByCategory)
            {
                Console.WriteLine($"Category: {group.Key}");

                foreach (var p in group)
                {
                    Console.WriteLine($"  {p.Element("Name")?.Value}");
                }
            }

            Console.WriteLine("----------Aggregation--------------");
            var avgPriceByCategory = products
                                    .GroupBy(p => (string)p.Element("Category"))
                                    .Select(g => new
                                    {
                                        Category = g.Key,
                                        AvgPrice = g.Average(p => (decimal)p.Element("Price"))
                                    });

            foreach (var item in avgPriceByCategory)
            {
                Console.WriteLine($"{item.Category} - Avg Price: {item.AvgPrice}");
            }


            Console.WriteLine("----------Transform XML--------------");
            XDocument transformedDoc = new XDocument(
                                            new XElement("AvailableProducts",
                                                products
                                                    .Where(p => (bool)p.Element("InStock"))
                                                    .Select(p =>
                                                        new XElement("Item",
                                                            new XAttribute("code", (string)p.Attribute("id")),
                                                            new XElement("Title", (string)p.Element("Name")),
                                                            new XElement("Cost", (decimal)p.Element("Price"))
                                                        )
                                                    )
                                            )
                                        );

            transformedDoc.Save("AvailableProducts.xml");
        }
    }
}