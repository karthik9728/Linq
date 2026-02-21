using Linq.Utils;
using Linq.Utils.Models;

namespace LinqToObjects
{
    /// <summary>
    /// A sorting operation orders the elements of a sequence based on one or more attributes. The first sort criterion performs a primary sort on the elements. By specifying a second sort criterion, you can sort the elements within each primary sort group.
    /// <seealso href="https://learn.microsoft.com/en-us/dotnet/csharp/linq/standard-query-operators/sorting-data">Sorting Data (C#)</seealso>
    /// </summary>
    public static class Sorting
    {
        private static List<StudentExamReport> StudentExamReports = DataProvider.GetStudentExamReports();

        public static void LinqOrderBy()
        {
            Console.WriteLine("----------Origianl Data----------");
            // Table Header
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("{0,-5} {1,-20} {2,-10} {3,-5}", "Id", "Name", "Mark", "Grade");
            Console.WriteLine("-------------------------------------------------");

            // Table Rows
            foreach (var student in StudentExamReports)
            {
                Console.WriteLine("{0,-5} {1,-20} {2,-10} {3,-5}",
                    student.Id,
                    student.Name,
                    student.TotalMark,
                    student.Grade);
            }

            Console.WriteLine("-------------------------------------------------");

            // Query Syntax
            Console.WriteLine("----------Query Syntax----------");

            var linqQuery = from r in StudentExamReports orderby r.Grade select r;

            // Table Header
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("{0,-5} {1,-20} {2,-10} {3,-5}", "Id", "Name", "Mark", "Grade");
            Console.WriteLine("-------------------------------------------------");
            foreach (var student in linqQuery)
            {
                Console.WriteLine("{0,-5} {1,-20} {2,-10} {3,-5}",
                   student.Id,
                   student.Name,
                   student.TotalMark,
                   student.Grade);
            }

            // Method Syntax
            Console.WriteLine("---------Method Syntax----------");

            var linqMethod = StudentExamReports.OrderBy(x => x.Grade);

            // Table Header
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("{0,-5} {1,-20} {2,-10} {3,-5}", "Id", "Name", "Mark", "Grade");
            Console.WriteLine("-------------------------------------------------");
            foreach (var student in linqQuery)
            {
                Console.WriteLine("{0,-5} {1,-20} {2,-10} {3,-5}",
                   student.Id,
                   student.Name,
                   student.TotalMark,
                   student.Grade);
            }
        }

        public static void LinqOrderByDescending()
        {
            Console.WriteLine("----------Origianl Data----------");
            // Table Header
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("{0,-5} {1,-20} {2,-10} {3,-5}", "Id", "Name", "Mark", "Grade");
            Console.WriteLine("-------------------------------------------------");

            // Table Rows
            foreach (var student in StudentExamReports)
            {
                Console.WriteLine("{0,-5} {1,-20} {2,-10} {3,-5}",
                    student.Id,
                    student.Name,
                    student.TotalMark,
                    student.Grade);
            }

            Console.WriteLine("-------------------------------------------------");

            // Query Syntax
            Console.WriteLine("----------Query Syntax----------");

            var linqQuery = from r in StudentExamReports orderby r.Grade descending select r;

            // Table Header
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("{0,-5} {1,-20} {2,-10} {3,-5}", "Id", "Name", "Mark", "Grade");
            Console.WriteLine("-------------------------------------------------");
            foreach (var student in linqQuery)
            {
                Console.WriteLine("{0,-5} {1,-20} {2,-10} {3,-5}",
                   student.Id,
                   student.Name,
                   student.TotalMark,
                   student.Grade);
            }

            // Method Syntax
            Console.WriteLine("---------Method Syntax----------");

            var linqMethod = StudentExamReports.OrderByDescending(x => x.Grade);

            // Table Header
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("{0,-5} {1,-20} {2,-10} {3,-5}", "Id", "Name", "Mark", "Grade");
            Console.WriteLine("-------------------------------------------------");
            foreach (var student in linqQuery)
            {
                Console.WriteLine("{0,-5} {1,-20} {2,-10} {3,-5}",
                   student.Id,
                   student.Name,
                   student.TotalMark,
                   student.Grade);
            }
        }

        public static void LinqThenBy()
        {
            Console.WriteLine("----------Origianl Data----------");
            // Table Header
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("{0,-5} {1,-20} {2,-10} {3,-5}", "Id", "Name", "Mark", "Grade");
            Console.WriteLine("-------------------------------------------------");

            // Table Rows
            foreach (var student in StudentExamReports)
            {
                Console.WriteLine("{0,-5} {1,-20} {2,-10} {3,-5}",
                    student.Id,
                    student.Name,
                    student.TotalMark,
                    student.Grade);
            }

            Console.WriteLine("-------------------------------------------------");

            // Query Syntax
            Console.WriteLine("----------Query Syntax----------");

            var linqQuery = from r in StudentExamReports orderby r.Grade, r.TotalMark select r;

            // Table Header
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("{0,-5} {1,-20} {2,-10} {3,-5}", "Id", "Name", "Mark", "Grade");
            Console.WriteLine("-------------------------------------------------");
            foreach (var student in linqQuery)
            {
                Console.WriteLine("{0,-5} {1,-20} {2,-10} {3,-5}",
                   student.Id,
                   student.Name,
                   student.TotalMark,
                   student.Grade);
            }

            // Method Syntax
            Console.WriteLine("---------Method Syntax----------");

            var linqMethod = StudentExamReports.OrderBy(x => x.Grade).ThenBy(x => x.TotalMark);

            // Table Header
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("{0,-5} {1,-20} {2,-10} {3,-5}", "Id", "Name", "Mark", "Grade");
            Console.WriteLine("-------------------------------------------------");
            foreach (var student in linqQuery)
            {
                Console.WriteLine("{0,-5} {1,-20} {2,-10} {3,-5}",
                   student.Id,
                   student.Name,
                   student.TotalMark,
                   student.Grade);
            }
        }

        public static void LinqThenByDescending()
        {
            Console.WriteLine("----------Origianl Data----------");
            // Table Header
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("{0,-5} {1,-20} {2,-10} {3,-5}", "Id", "Name", "Mark", "Grade");
            Console.WriteLine("-------------------------------------------------");

            // Table Rows
            foreach (var student in StudentExamReports)
            {
                Console.WriteLine("{0,-5} {1,-20} {2,-10} {3,-5}",
                    student.Id,
                    student.Name,
                    student.TotalMark,
                    student.Grade);
            }

            Console.WriteLine("-------------------------------------------------");

            // Query Syntax
            Console.WriteLine("----------Query Syntax----------");

            var linqQuery = from r in StudentExamReports orderby r.Grade, r.TotalMark descending select r;

            // Table Header
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("{0,-5} {1,-20} {2,-10} {3,-5}", "Id", "Name", "Mark", "Grade");
            Console.WriteLine("-------------------------------------------------");
            foreach (var student in linqQuery)
            {
                Console.WriteLine("{0,-5} {1,-20} {2,-10} {3,-5}",
                   student.Id,
                   student.Name,
                   student.TotalMark,
                   student.Grade);
            }

            // Method Syntax
            Console.WriteLine("---------Method Syntax----------");

            var linqMethod = StudentExamReports.OrderBy(x => x.Grade).ThenByDescending(x => x.TotalMark);

            // Table Header
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("{0,-5} {1,-20} {2,-10} {3,-5}", "Id", "Name", "Mark", "Grade");
            Console.WriteLine("-------------------------------------------------");
            foreach (var student in linqQuery)
            {
                Console.WriteLine("{0,-5} {1,-20} {2,-10} {3,-5}",
                   student.Id,
                   student.Name,
                   student.TotalMark,
                   student.Grade);
            }
        }

        public static void LinqReverse()
        {
            //Query Syntax is Not applicable

            // Method Syntax
            Console.WriteLine("---------Method Syntax----------");

            StudentExamReports.Reverse();
            // Table Header
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("{0,-5} {1,-20} {2,-10} {3,-5}", "Id", "Name", "Mark", "Grade");
            Console.WriteLine("-------------------------------------------------");

            // Table Rows
            foreach (var student in StudentExamReports)
            {
                Console.WriteLine("{0,-5} {1,-20} {2,-10} {3,-5}",
                    student.Id,
                    student.Name,
                    student.TotalMark,
                    student.Grade);
            }

            Console.WriteLine("-------------------------------------------------");
        }
    }
}
