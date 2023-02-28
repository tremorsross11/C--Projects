using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDb1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var dbContext = new StudentDbContext())
            {
                

                dbContext.Students.Add(new Student
                {
                    Name = "John Smith",
                    Email = "john@example.com",
                    EnrollmentDate = DateTime.Now
                });

                dbContext.SaveChanges();
            }
        }
    }
}

public class Student
{
    public int StudentId { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public DateTime EnrollmentDate { get; set; }
}

public class StudentDbContext : DbContext
{
    public DbSet<Student> Students { get; set; }

    
}
