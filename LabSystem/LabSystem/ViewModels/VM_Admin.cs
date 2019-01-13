using LabSystem.Abstracts;
using LabSystem.Models;
using System.Collections.Generic;

namespace LabSystem.ViewModels
{
    public class VM_Admin
    {
        public List<Employee> employeeList { get; set; }
        public List<Customer> customerList { get; set; }
        public List<ENUM_Role> roleList { get; set; }
    }   
}