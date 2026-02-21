using Linq.Utils.Common;

namespace Linq.Utils.Models
{
    public class StudentExamReport
    {
        public StudentExamReport(int id, string name, int totalMark, Grade grade)
        {
            Id = id;
            Name = name;
            TotalMark = totalMark;
            Grade = grade;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public int TotalMark { get; set; } 

        public Grade Grade { get; set; }
    }
}
