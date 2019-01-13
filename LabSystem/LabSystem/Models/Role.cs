using LabSystem.Abstracts;

namespace LabSystem.Models
{
    public class Role
    {
        public int RoleId { get; set; }
        public ENUM_Role RoleType { get; set; }
        public int EmployeeId { get; set; }
    }
}