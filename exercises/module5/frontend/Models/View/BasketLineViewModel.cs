using System;

namespace GloboTicket.Frontend.Models.View
{
    public class BasketLineViewModel
    {
        public Guid LineId { get; set; }
        public Guid EventId { get; set; }
        public string EventName { get; set; }
        public DateTimeOffset Date { get; set; }
        public decimal Price { get; set; }
        public decimal OriginalPrice { get; set; }
        public bool IsOnSpecialOffer { get; set; }
        public int Quantity { get; set; }
        
        // Venue information
        public string VenueName { get; set; }
        public string VenueCity { get; set; }
        public string VenueState { get; set; }
    }
}
