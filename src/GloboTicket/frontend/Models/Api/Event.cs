using System;

namespace GloboTicket.Frontend.Models.Api
{
    public class Event
    {
        public Guid EventId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal OriginalPrice { get; set; }
        public string Artist { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public bool IsOnSpecialOffer { get; set; }
        
        // Venue information
        public Guid VenueId { get; set; }
        public string VenueName { get; set; }
        public string VenueCity { get; set; }
        public string VenueState { get; set; }
        public string VenueAddress { get; set; }
        public int VenueSeatsAvailable { get; set; }
    }
}
