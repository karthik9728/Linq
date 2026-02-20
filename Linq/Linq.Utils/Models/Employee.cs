using Linq.Utils.Common;

namespace Linq.Utils.Models
{
    public class Employee
    {
        public Employee()
        {
            
        }

        public Employee(int id, string name, string emailAddress, DateOnly dateOfJoining, Team team)
        {
            Id = id;
            Name = name;
            EmailAddress = emailAddress;
            DateOfJoining = dateOfJoining;
            Team = team;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string EmailAddress { get; set; }

        public DateOnly DateOfJoining { get; set; }

        public Team Team { get; set; }
    }
}
