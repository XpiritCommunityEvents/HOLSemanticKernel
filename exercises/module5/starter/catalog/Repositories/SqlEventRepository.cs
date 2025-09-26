using GloboTicket.Catalog.DbContexts;
using Microsoft.EntityFrameworkCore;


namespace GloboTicket.Catalog.Repositories;

public class SqlEventRepository : IEventRepository
{
    private readonly EventCatalogDbContext _eventCatalogDbContext;


    private readonly ILogger<SqlEventRepository> logger;

    public SqlEventRepository(EventCatalogDbContext eventCatalogDbContext,
        ILogger<SqlEventRepository> logger)
    {
        this.logger = logger;
        _eventCatalogDbContext = eventCatalogDbContext;
    }

    public async Task<IEnumerable<Event>> GetEvents()
    {
        var sortedEvents = await _eventCatalogDbContext.Events
            .Include(e => e.Venue)
            .OrderByDescending(e => e.IsOnSpecialOffer)
            .ThenBy(e => e.Date)
            .ThenBy(e => e.Venue.City) 
            .ToListAsync();
            
        return sortedEvents;
    }

    public async Task<Event> GetEventById(Guid eventId)
    {
        var @event = await _eventCatalogDbContext.Events
            .Include(e => e.Venue)
            .FirstOrDefaultAsync(e => e.EventId == eventId);
            
        if (@event == null)
        {
            throw new InvalidOperationException("Event not found");
        }
        return @event;
    }

    void IEventRepository.UpdateSpecialOffer()
    {
        // Reset any existing special offers first
        var currentOffers = _eventCatalogDbContext.Events.Where(e => e.IsOnSpecialOffer).ToList();
        foreach (var offer in currentOffers)
        {
            offer.Price = offer.OriginalPrice;
            offer.IsOnSpecialOffer = false;
        }

        // Get all events to select a random one
        var allEvents = _eventCatalogDbContext.Events.ToList();
        if (allEvents.Count == 0)
        {
            logger.LogWarning("No events found to put on special offer");
            return;
        }

        // Pick a random event for special offer
        var random = new Random();
        var specialOfferEvent = allEvents[random.Next(0, allEvents.Count)];
        
        // Store the original price before discount
        specialOfferEvent.OriginalPrice = specialOfferEvent.Price;
        
        // Apply 20 percent discount and round to psychological price
        var discountedPrice = specialOfferEvent.Price * 0.8m;
        specialOfferEvent.Price = Math.Round(discountedPrice - 0.01m, 2);
        
        // Mark as special offer
        specialOfferEvent.IsOnSpecialOffer = true;
        
        // Save changes to the database
        _eventCatalogDbContext.SaveChanges();
        
        logger.LogInformation($"Event {specialOfferEvent.Name} is now on special offer at ${specialOfferEvent.Price} (was ${specialOfferEvent.OriginalPrice})");
    }
}
