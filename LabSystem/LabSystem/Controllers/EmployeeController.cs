using LabSystem.Configuration;
using System.Web.Mvc;

namespace LabSystem.Controllers
{
    public class EmployeeController : Controller
    {
        private DatabaseContext db = new DatabaseContext();

        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddSurvey()
        {

            db.Surveys.Add();    
            return View();
        }

        public ActionResult EditSurvey()
        {
            return View();
        }

        public ActionResult EditOrder()
        {
            return View();
        }

        public ActionResult DeleteOrder(int orderId)
        {
            return View();
        }

        public ActionResult ActivateCustomer()
        {
            return View();
        }

        public ActionResult EditUser()
        {
            return View();
        }


    }
}