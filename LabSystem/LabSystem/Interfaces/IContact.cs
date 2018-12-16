namespace LabSystem.Interfaces
{
    public interface IContact
    {
        string Email { get; set; }
        string Phone { get; set; }

        string Voivodeship { get; set; }
        string Commune { get; set; }
        string City { get; set; }
        string PostalCode { get; set; }
        string Street { get; set; }
    }
}
