using Microsoft.SemanticKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static UseSemanticKernelFromNET.Plugins.HotelPlugin;

namespace agent_demo01.Plugins
{
    internal class TransportationBookings
    {
        [KernelFunction("select_ride_for_hotel_to_venue"), 
         Description("Returns available rides in a city for a date")]
        [return: Description("The available ride information, containing Ride Type, estimated price, name of the service provider")]
        public AvailableRide[] SelectRideForHotelToVenue(
        [Description("City where you need the ride")]
            string city,
        [Description("Date the hotel night is required")]
        DateTime dateOfBooking)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Searching for available Rides in {city} for date {dateOfBooking.ToShortDateString()}");
            Console.ResetColor();

            return availableRides
                 .Where(r => r.City.Equals(city, StringComparison.OrdinalIgnoreCase))
                 .ToArray();
        }

        [KernelFunction("book_a_ride"),
         Description("makes it possible to book a selected ride")]
        [return: Description("returns if the booking was successfull")]
        public bool BookARide(int rideID)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Booked the ride with id: {rideID}");
            Console.ResetColor();
            return true;
        }

        private readonly AvailableRide[] availableRides = new AvailableRide[]
        {
            new AvailableRide { RideId = 1, RideType = "Taxi", Price = 25.00m, ServiceName = "City Cabs", City = "New York" },
            new AvailableRide { RideId = 2, RideType = "Ride Share", Price = 20.00m, ServiceName = "Uber", City = "New York" },
            new AvailableRide { RideId = 3, RideType = "Limousine", Price = 100.00m, ServiceName = "Luxury Rides", City = "Los Angeles" },
            new AvailableRide { RideId = 4, RideType = "Taxi", Price = 30.00m, ServiceName = "LA Cabs", City = "Los Angeles" },
            new AvailableRide { RideId = 5, RideType = "Ride Share", Price = 22.00m, ServiceName = "Lyft", City = "Chicago" },
            new AvailableRide { RideId = 6, RideType = "Taxi", Price = 28.00m, ServiceName = "Chicago Taxis", City = "Chicago" },
            new AvailableRide { RideId = 7, RideType = "Shuttle", Price = 15.00m, ServiceName = "City Shuttle", City = "Miami" },
            new AvailableRide { RideId = 8, RideType = "Ride Share", Price = 18.00m, ServiceName = "Uber", City = "Miami" },
            new AvailableRide { RideId = 9, RideType = "Taxi", Price = 27.00m, ServiceName = "Miami Cabs", City = "Miami" },
            new AvailableRide { RideId = 10, RideType = "Limousine", Price = 120.00m, ServiceName = "Elite Rides", City = "New York" },
            new AvailableRide { RideId = 11, RideType = "Taxi", Price = 26.00m, ServiceName = "Downtown Taxis", City = "San Francisco" },
            new AvailableRide { RideId = 12, RideType = "Ride Share", Price = 21.00m, ServiceName = "Lyft", City = "San Francisco" },
            new AvailableRide { RideId = 13, RideType = "Shuttle", Price = 16.00m, ServiceName = "Airport Shuttle", City = "San Francisco" },
            new AvailableRide { RideId = 14, RideType = "Taxi", Price = 29.00m, ServiceName = "City Cabs", City = "Seattle" },          
        };

        public class AvailableRide
        {
            public int RideId { get; set; }
            public string RideType { get; set; }
            public decimal Price { get; set; }
            public string ServiceName { get; set; }
            public string City { get; set; }

        }
    }
}
