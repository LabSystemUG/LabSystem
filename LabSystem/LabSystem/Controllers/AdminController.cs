using LabSystem.Abstracts;
using LabSystem.Configuration;
using LabSystem.Models;
using LabSystem.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace LabSystem.Controllers
{
    public class AdminController : EmployeeController
    {

        private DatabaseContext db = new DatabaseContext();

        // GET: Admin
        public ActionResult Home()
        {
            var viewModel = new VM_Admin {
                employeeList = db.Employees.ToList(),
                customerList = db.Customers.ToList(),
                roleList = new List<ENUM_Role>(Enum.GetValues(typeof(ENUM_Role)) as IEnumerable<ENUM_Role>)
            };
            return View(viewModel);
        }
        public bool ChangeUserActivityStatus(int UserId)
        {
            try
            {
                var user = db.Employees.Where(x => x.Id == UserId).FirstOrDefault();
                user.IsActive = user.IsActive ? false : true;
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool UpdateRole(int roleId, int employeeID)
        {
            if (db.Roles.Where(x => (int)x.RoleType == roleId && x.EmployeeId == employeeID).Any())
                return false;
            try
            {
                var role = new Role() { RoleType = (ENUM_Role)roleId, EmployeeId = employeeID };
                db.Roles.Add(role);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteUser(int UserId)
        {
            return true;
        }

        // BEZSENSU - chyba
        //public ActionResult AddEmployee()
        //{
        //    return View();
        //}


    }
}