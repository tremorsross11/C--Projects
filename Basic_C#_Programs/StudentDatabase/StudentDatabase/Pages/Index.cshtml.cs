using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace StudentDatabase.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

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




    }
}