using System;
using System.Collections.Generic;


using (var dbContext = new StudentDbContext())
{
    dbContext.Database.EnsureCreated();

    dbContext.Students.Add(new Student
    {
        Name = "John Smith",
        Email = "john@example.com",
        EnrollmentDate = DateTime.Now
    });

    dbContext.SaveChanges();
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

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=StudentDatabase;Trusted_Connection=True;");
    }
}



