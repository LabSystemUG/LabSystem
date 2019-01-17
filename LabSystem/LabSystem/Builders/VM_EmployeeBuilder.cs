using LabSystem.Configuration;
using LabSystem.Models;
using LabSystem.ViewModels;
using System.Linq;
using System.Web;

namespace LabSystem.Builders
{
    public class VM_EmployeeBuilder
    {
        private VM_Employee _EmployeeVM;
        private DatabaseContext _db;
        private Employee _Employee;

        public VM_EmployeeBuilder()
        {
            this._Employee = _db.Employees.Where(x => x.Id == (HttpContext.Current.User as Employee).Id).FirstOrDefault();
            _db = new DatabaseContext();
            this._EmployeeVM = new VM_Employee();
        }

        public void Customers()
        {
            this._EmployeeVM.Customers = _db.Customers.Where(x => x.Id > 0).ToList();
        }

        public void Orders()
        {
            this._EmployeeVM.Orders = _db.Orders.Where(x => x.EmployeeId == this._Employee.Id).ToList();
        }

        public void Laboratory()
        {
            // TODO ???????????????????????????????????????????/
            this._EmployeeVM.Laboratory = _db.Laboratories.Where(x => x.LaboratoryId > 0).FirstOrDefault();
        }

        public void Reports()
        {
            var ordersIds = this._EmployeeVM.Orders.Select(x => x.InvoiceId).ToList();
            this._EmployeeVM.Reports = _db.Reports.Where(x => ordersIds.Contains(x.ReportId)).ToList();
        }

        public void Invoices() {
            var ordersIds = this._EmployeeVM.Orders.Select(x => x.InvoiceId).ToList();
            this._EmployeeVM.Invoices = _db.Invoices.Where(x => ordersIds.Contains(x.InvoiceId)).ToList();

        }

        public void Samples() {
            var surveysIds = this._EmployeeVM.Surveys.Select(x => x.SurveyId).ToList();
            this._EmployeeVM.Samples = _db.Samples.Where(x => surveysIds.Contains(x.SurveyId)).ToList();
        }

        public void Surveys() {
            var ordersIds = this._EmployeeVM.Orders.Select(x => x.OrderId).ToList();
            this._EmployeeVM.Surveys = _db.Surveys.Where(x => ordersIds.Contains(x.OrderId)).ToList();
        }

    }
}