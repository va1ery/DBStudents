using static System.Console; 
using Microsoft.EntityFrameworkCore; 
using System.Linq;
using SchoolDB.Models;
using SchoolDB.Data;

namespace SchoolDB
{
    class Program
    {
        static void QueryingStudents()
        {
        using (var db = new SchoolContext())
            {
                WriteLine("Courses and Students:");
                // a query to get all categories and their related products 
                IQueryable<Enrollment> ens = db.Enrollments
                .Include(c => c.Student);
                foreach (Enrollment e in ens)
                {
                WriteLine($"Course {e.CourseID} has {e.Student.LastName} student.");
                }
            }
        }
        static void Main(string[] args)
            {
            // var context = new SchoolContext();
            // DbInitializer.Initialize(context);
            QueryingStudents();
            }
    }
}

