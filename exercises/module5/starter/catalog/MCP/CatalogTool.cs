using System.ComponentModel;
using GloboTicket.Catalog.Repositories;
using ModelContextProtocol.Protocol;
using ModelContextProtocol.Server;

namespace GloboTicket.Catalog.MCP;

[McpServerToolType]
public class CatalogTool(IEventRepository eventRepository)
{
    [McpServerTool(Destructive = false), Description("Get all real-time information of all known concerts, events and performances in the catalog for a given artist")]
    public async Task<IEnumerable<ContentBlock>> GetEventsByArtist([Description("Artist name")] string artist)
    {
        var events = await eventRepository.GetEvents();

        return events
            .Where(e => e.Artist.Contains(artist, StringComparison.OrdinalIgnoreCase))
            .Take(20)
            .Select(MapEvent);
    }

    [McpServerTool(Destructive = false), Description("Gets events, concerts, performances within a specified date range")]
    public async Task<IEnumerable<ContentBlock>> GetEventsInDateRange([Description("Start date")] DateTime startDate, [Description("End date")]DateTime endDate)
    {
        var events = await eventRepository.GetEvents();
        return events
            .Where(e => e.Date >= startDate && e.Date <= endDate)
            .Take(20)
            .Select(MapEvent);
    }

    [McpServerTool(Destructive = false), Description("Gets events, concerts, performances in a specified location (city or state)")]
    public async Task<IEnumerable<ContentBlock>> GetEventsInLocation([Description("Name of a city or state")] string location)
    {
        var events = await eventRepository.GetEvents();
        return events
            .Where(e => e.Venue.City.Contains(location, StringComparison.OrdinalIgnoreCase) || e.Venue.State.Contains(location, StringComparison.OrdinalIgnoreCase))
            .Take(20)
            .Select(MapEvent);
    }

    [McpServerTool(Destructive = false), Description("Gets names of artists with known events")]
    public async Task<IEnumerable<ContentBlock>> GetArtists()
    {
        var events = await eventRepository.GetEvents();
        return events
            .GroupBy(e => e.Artist)
            .Take(20)
            .Select(g => new TextContentBlock
            {
                Text = $"Artist: {g.Key}, Locations: {string.Join(", ", g.Select(e => e.Venue.City).Distinct())}",
                Annotations = new()
                {
                    Audience = [Role.Assistant]
                }
            });
    }

    [McpServerTool(Destructive = false), Description("Gets full details of a specific event by its unique identifier")]
    public async Task<ContentBlock> GetEventDetails(Guid id)
    {
        var @event = await eventRepository.GetEventById(id);
        return new TextContentBlock
        {
            Text = $"""
            {@event.Name}
            Artist: {@event.Artist}
            Date: {@event.Date:yyyy-MM-dd} at {@event.Venue.Name}, {@event.Venue.Address}, {@event.Venue.City}, {@event.Venue.State}, {@event.Venue.ZipCode}.
            Seats available: {@event.Venue.SeatsAvailable}
            
            {@event.Description}

            Price: {@event.Price}
            """,
            Annotations = new()
            {
                Audience = [Role.Assistant]
            }
        };
    }

    private static ContentBlock MapEvent(Event @event) =>
        new TextContentBlock
        {
            Text = $"ID: {@event.EventId}: {@event.Artist} - {@event.Date:yyyy-MM-dd} at {@event.Venue} in {@event.Venue.City}. Seats available: {@event.Venue.SeatsAvailable}",
            Annotations = new()
            {
                Audience = [Role.Assistant]
            }
        };
}
