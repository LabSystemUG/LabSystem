using LabSystem.Abstracts;

namespace LabSystem.Models
{
    public class Customer : A_User
    {
        public bool IsActive { get; set; }
        public string Address { get; set; }

        public Customer()
        {
            IsActive = false;
        }
    }
}