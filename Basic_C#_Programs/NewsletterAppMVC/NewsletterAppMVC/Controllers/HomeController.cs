using Microsoft.AspNetCore.Mvc;
using NewsletterAppMVC.Models;
using NewsletterAppMVC.ViewModel;
using System.Data.SqlClient;
using System.Diagnostics;

namespace NewsletterAppMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly string connectionString = @"Data Source=LAPTOP-JSOPVH70\SQLEXPRESS;Initial Catalog=Newsletter;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SignUp(string FirstName, string LastName, string EmailAddress)
        {
            if (string.IsNullOrEmpty(FirstName) || string.IsNullOrEmpty(LastName) || string.IsNullOrEmpty(EmailAddress))
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            else
            {
                string connectionString = @"Data Source=LAPTOP-JSOPVH70\SQLEXPRESS;Initial Catalog=Newsletter;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

                string queryString = @"INSERT INTO SignUps (FirstName, LastName, EmailAddress, SocialSecurityNumber) VALUES
                                        (@FirstName, @LastName, @EmailAddress, @SocialSecurityNumber)";
                
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.Parameters.Add("@FirstName", System.Data.SqlDbType.VarChar);
                    command.Parameters.Add("@LastName", System.Data.SqlDbType.VarChar);
                    command.Parameters.Add("@EmailAddress", System.Data.SqlDbType.VarChar);

                    command.Parameters["@FirstName"].Value = FirstName;
                    command.Parameters["@LastName"].Value = LastName;
                    command.Parameters["@EmailAddress"].Value = EmailAddress;

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();


                }
                return View("Success");
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Admin()
        {
            string queryString = @"SELECT Id, FirstName, LastName, EmailAddress from SignUps";
            List<NewsletterSignUp> signups = new List<NewsletterSignUp>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var signup = new NewsletterSignUp();
                    signup.Id = Convert.ToInt32(reader["Id"]);
                    signup.FirstName = reader["FirstName"].ToString();
                    signup.LastName = reader["LastName"].ToString();
                    signup.EmailAddress = reader["EmailAddress"].ToString();
                    signup.SocialSecurityNumber = reader["SocialSecurityNumber"].ToString();
                    signups.Add(signup);

                }
            }
            var signupVms = new List<SignUpVM>();
            foreach (var signup in signups)
            {
                var signupVm = new SignUpVM();
                signupVm.FirstName = signup.FirstName;
                signupVm.LastName = signup.LastName;
                signupVm.EmailAddress = signup.EmailAddress;
                signupVms.Add(signupVm);


            }
            
            return View(signupVms);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}