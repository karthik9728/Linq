using Linq.Utils.Common;

namespace Linq.Utils.Models
{
    public class Manager : Employee
    {
        public Manager()
        {
        }

        public Manager(int id, string name, string emailAddress, DateOnly dateOfJoining, Team team) : base(id, name, emailAddress, dateOfJoining, team)
        {
        }

        public void ConductMeeting()
        {
            Console.WriteLine($"{Name} is conducting a meeting.");
        }
    }
}
