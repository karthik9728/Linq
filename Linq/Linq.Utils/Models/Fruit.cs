namespace Linq.Utils.Models
{
    public class Fruit
    {
        public Fruit(int id, string name, int colorId)
        {
            Id = id;
            Name = name;
            ColorId = colorId;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int ColorId { get; set; }
    }
}
