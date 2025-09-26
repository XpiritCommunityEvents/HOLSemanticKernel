namespace GloboTicket.Catalog;

public class Venue
{
    public Guid VenueId { get; set; }
    public string Name { get; set; }
    public int SeatsAvailable { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string ZipCode { get; set; }
    
    // Navigation property for events held at this venue - MUST be virtual for lazy loading
    public virtual ICollection<Event> Events { get; set; } = new List<Event>();
}
