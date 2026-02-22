using Linq.Utils;
using Linq.Utils.Models;

namespace LinqToObjects
{
    /// <summary>
    /// <seealso href="https://learn.microsoft.com/en-us/dotnet/csharp/linq/standard-query-operators/join-operations">Join operations in LINQ</seealso>
    /// </summary>
    public class JoinOperations
    {
        private static List<Fruit> Fruits = DataProvider.GetFruits();
        private static List<Color> Colors = DataProvider.GetColors();
        private static List<Student> Students = DataProvider.GetStudents();
        private static List<Course> Courses = DataProvider.GetCourses();

        public static void LinqJoin()
        {
            // Query Syntax
            Console.WriteLine("----------Query Syntax----------");

            var linqQuery = from f in Fruits 
                        join c in Colors 
                        on f.ColorId equals c.Id 
                        select new
                        {
                            Name = f.Name,
                            Color = c.Name
                        };

            foreach (var x in linqQuery) 
            {
                Console.WriteLine($"Name:{x.Name}, Color:{x.Color}");
            }

            // Method Syntax
            Console.WriteLine("---------Method Syntax----------");

            var linqMethod = Fruits.Join(Colors, f => f.ColorId, c => c.Id,
                            (f, c) => new
                            {
                                Name = f.Name,
                                Color = c.Name
                            });

            foreach (var x in linqMethod)
            {
                Console.WriteLine($"Name:{x.Name}, Color:{x.Color}");
            }
        }

        public static void LinqLeftJoin()
        {
            // Query Syntax
            Console.WriteLine("----------Query Syntax----------");

            var linqQuery = from f in Fruits
                            join c in Colors
                            on f.ColorId equals c.Id
                            into temp
                            from c in temp.DefaultIfEmpty()
                            select new
                            {
                                Name = f.Name,
                                Color = c?.Name ?? "No Color"
                            };

            foreach (var x in linqQuery)
            {
                Console.WriteLine($"Name:{x.Name}, Color:{x.Color}");
            }

            // Method Syntax
            Console.WriteLine("---------Method Syntax----------");

            var linqMethod = Fruits.LeftJoin(Colors, f => f.ColorId, c => c.Id,
                            (f, c) => new
                            {
                                Name = f.Name,
                                Color = c?.Name ?? "No Color"
                            });

            foreach (var x in linqMethod)
            {
                Console.WriteLine($"Name:{x.Name}, Color:{x.Color}");
            }
        }

        public static void LinqRightJoin()
        {
            // Query Syntax
            Console.WriteLine("----------Query Syntax----------");

            var linqQuery = from c in Colors
                            join f in Fruits
                            on c.Id equals f.ColorId
                            into temp
                            from f in temp.DefaultIfEmpty()
                            select new
                            {
                                Name = f?.Name ?? "No Fruit",
                                Color = c.Name
                            };

            foreach (var x in linqQuery)
            {
                Console.WriteLine($"Name:{x.Name}, Color:{x.Color}");
            }

            // Method Syntax
            Console.WriteLine("---------Method Syntax----------");

            var linqMethod = Fruits.RightJoin(Colors, f => f.ColorId, c => c.Id,
                            (f, c) => new
                            {
                                Name = f?.Name ?? "No Fruit",
                                Color = c.Name
                            });

            foreach (var x in linqMethod)
            {
                Console.WriteLine($"Name:{x.Name}, Color:{x.Color}");
            }
        }

        public static void LinqGroupJoin()
        {
            // Query Syntax
            Console.WriteLine("----------Query Syntax----------");
            var linqQuery = from s in Students
                        join c in Courses
                        on s.Id equals c.StudentId
                        into courseGroup
                        select new
                        {
                            Student = s.Name,
                            Courses = courseGroup.Select(c => c.Name)
                        };

            foreach (var x in linqQuery)
            {
                Console.WriteLine($"Student: {x.Student}, Courses: {string.Join(", ", x.Courses.DefaultIfEmpty("No Course"))}");
            }

            // Method Syntax
            Console.WriteLine("---------Method Syntax----------");
            var linqMethod = Students.GroupJoin(
                Courses,
                s => s.Id,
                c => c.StudentId,
                (s, courseGroup) => new
                {
                    Student = s.Name,
                    Courses = courseGroup.Select(c => c.Name)
                }
            );

            foreach (var x in linqMethod)
            {
                Console.WriteLine($"Student: {x.Student}, Courses: {string.Join(", ", x.Courses.DefaultIfEmpty("No Course"))}");
            }
        }
    }
}
