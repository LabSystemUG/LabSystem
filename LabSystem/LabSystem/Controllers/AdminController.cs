using System.Web.Mvc;

namespace LabSystem.Controllers
{
    public class AdminController : EmployeeController
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DeleteUser()
        {
            return View();
        }

        public ActionResult AddEmployee()
        {
            return View();
        }




    }
}