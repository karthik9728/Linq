namespace Linq.Utils.Models
{
    public class Product
    {
        public Product(int id, string name, string category, int stock, decimal price)
        {
            Id = id;
            Name = name;
            Category = category;
            Stock = stock;
            Price = price;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
    }
}
