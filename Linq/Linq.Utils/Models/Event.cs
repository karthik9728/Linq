namespace Linq.Utils.Models
{
    public class Event
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<Employee> Employees { get; set; }
    }
}
