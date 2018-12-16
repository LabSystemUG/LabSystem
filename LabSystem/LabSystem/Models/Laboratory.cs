using LabSystem.Interfaces;

namespace LabSystem.Models
{
    public class Laboratory : IContact
    {
        public int LaboratoryId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public string Voivodeship { get; set; }
        public string Commune { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Street { get; set; }
        public string Phone { get; set; }
    }
}