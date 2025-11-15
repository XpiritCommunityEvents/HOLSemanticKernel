using Microsoft.SemanticKernel;
using System.ComponentModel;

namespace modulerag;

internal class RideInformationSystemService
{
    [KernelFunction("get_available_rides"),
        Description("Get available rides in a city for a given date")]
    public Ride[] GetAvailableRides([Description("City where you need the ride")] string city, [Description("Date the ride is required")] DateTime bookingDate)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"Searching for Rides for City: {city} and Date: {bookingDate}");
        Console.ResetColor(); 
        return availableRides
            .Where(r => r.City.Equals(city, StringComparison.OrdinalIgnoreCase))
            .ToArray();
    }
    
    [KernelFunction("book_a_ride"),
    Description("makes it possible to book a selected ride")]
    [return: Description("returns true if the booking was successfull")]
    public bool BookARide(int rideID)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"Booked the ride with id: {rideID}");
        Console.ResetColor();
        return true;
    }

    private readonly Ride[] availableRides =
    [
        new Ride { RideId = 1, RideType = "Taxi", Price = 25.00m, ServiceName = "City Cabs", City = "New York" },
        new Ride { RideId = 2, RideType = "Ride Share", Price = 20.00m, ServiceName = "Uber", City = "New York" },
        new Ride { RideId = 3, RideType = "Limousine", Price = 100.00m, ServiceName = "Luxury Rides", City = "Los Angeles" },
        new Ride { RideId = 4, RideType = "Taxi", Price = 30.00m, ServiceName = "LA Cabs", City = "Los Angeles" },
        new Ride { RideId = 5, RideType = "Ride Share", Price = 22.00m, ServiceName = "Lyft", City = "Chicago" },
        new Ride { RideId = 6, RideType = "Taxi", Price = 28.00m, ServiceName = "Chicago Taxis", City = "Chicago" },
        new Ride { RideId = 7, RideType = "Shuttle", Price = 15.00m, ServiceName = "City Shuttle", City = "Miami" },
        new Ride { RideId = 8, RideType = "Ride Share", Price = 18.00m, ServiceName = "Uber", City = "Miami" },
        new Ride { RideId = 9, RideType = "Taxi", Price = 27.00m, ServiceName = "Miami Cabs", City = "Miami" },
        new Ride { RideId = 10, RideType = "Limousine", Price = 120.00m, ServiceName = "Elite Rides", City = "New York" },
        new Ride { RideId = 11, RideType = "Taxi", Price = 26.00m, ServiceName = "Downtown Taxis", City = "San Francisco" },
        new Ride { RideId = 12, RideType = "Ride Share", Price = 21.00m, ServiceName = "Lyft", City = "San Francisco" },
        new Ride { RideId = 13, RideType = "Shuttle", Price = 16.00m, ServiceName = "Airport Shuttle", City = "San Francisco" },
        new Ride { RideId = 14, RideType = "Taxi", Price = 29.00m, ServiceName = "City Cabs", City = "Seattle" },
    ];
}

public class Ride
{
    public int RideId { get; set; }
    public string RideType { get; set; }
    public decimal Price { get; set; }
    public string ServiceName { get; set; }
    public string City { get; set; }
}
