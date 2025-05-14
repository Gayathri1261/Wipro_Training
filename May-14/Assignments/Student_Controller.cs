using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class StudentController : Controller
    {
        public string Index()
        {
            return "This is Student Controller";
        }
        public string GetStudentName()
        {
            return "Student name is Gayathri";
        }
        public string GetStudentPhone()
        {
            return "9876543456";
        }

    }
}
