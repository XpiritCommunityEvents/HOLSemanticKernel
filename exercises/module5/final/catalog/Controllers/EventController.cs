using Microsoft.AspNetCore.Mvc;
using GloboTicket.Catalog.Repositories;
using GloboTicket.Catalog.Models;

namespace GloboTicket.Catalog.Controllers;

[ApiController]
[Route("[controller]")]
public class EventController : ControllerBase
{
    private readonly IEventRepository _eventRepository;


    private readonly ILogger<EventController> _logger;

    public EventController(IEventRepository eventRepository, ILogger<EventController> logger)
    {
        _eventRepository = eventRepository;
        _logger = logger;
    }

    [HttpGet(Name = "GetEvents")]
    public async Task<IActionResult> GetAll()
    {
        var events = await _eventRepository.GetEvents();
        var eventDtos = events.Select(e => new EventDto
        {
            EventId = e.EventId,
            Name = e.Name,
            Price = e.Price,
            OriginalPrice = e.OriginalPrice,
            Artist = e.Artist,
            Date = e.Date,
            Description = e.Description,
            ImageUrl = e.ImageUrl,
            IsOnSpecialOffer = e.IsOnSpecialOffer,
            VenueId = e.VenueId,
            VenueName = e.Venue?.Name ?? "Unknown Venue",
            VenueCity = e.Venue?.City ?? "Unknown City",
            VenueState = e.Venue?.State ?? "Unknown State",
            VenueAddress = e.Venue?.Address ?? "Unknown Address",
            VenueSeatsAvailable = e.Venue?.SeatsAvailable ?? 0
        });
        
        return Ok(eventDtos);
    }

    [HttpGet("{id}", Name = "GetById")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var eventEntity = await _eventRepository.GetEventById(id);
        var eventDto = new EventDto
        {
            EventId = eventEntity.EventId,
            Name = eventEntity.Name,
            Price = eventEntity.Price,
            OriginalPrice = eventEntity.OriginalPrice,
            Artist = eventEntity.Artist,
            Date = eventEntity.Date,
            Description = eventEntity.Description,
            ImageUrl = eventEntity.ImageUrl,
            IsOnSpecialOffer = eventEntity.IsOnSpecialOffer,
            VenueId = eventEntity.VenueId,
            VenueName = eventEntity.Venue?.Name ?? "Unknown Venue",
            VenueCity = eventEntity.Venue?.City ?? "Unknown City",
            VenueState = eventEntity.Venue?.State ?? "Unknown State",
            VenueAddress = eventEntity.Venue?.Address ?? "Unknown Address",
            VenueSeatsAvailable = eventEntity.Venue?.SeatsAvailable ?? 0
        };
        
        return Ok(eventDto);
    }
}
