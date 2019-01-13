using LabSystem.Abstracts;
using System.Collections.Generic;

namespace LabSystem.Models
{
    public class Employee : A_User
    {
        public List<Role> Roles { get; set; }
    }
}