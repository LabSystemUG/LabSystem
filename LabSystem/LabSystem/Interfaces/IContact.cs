namespace LabSystem.Interfaces
{
    public interface IContact
    {
        string Voivodeship { get; set; }
        string Commune { get; set; }
        string City { get; set; }
        string PostalCode { get; set; }
        string Street { get; set; }
        string Phone { get; set; }
    }
}
