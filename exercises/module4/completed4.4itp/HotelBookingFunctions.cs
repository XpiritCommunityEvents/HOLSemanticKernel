using Microsoft.SemanticKernel;
using System.ComponentModel;

namespace modulerag;

public class HotelBookingFunctions
{
    [KernelFunction, Description("Returns available rooms in a city for a date")]
    [return: Description("The available room information, containing Type, Price per night, name of the hotel, number of people per room, amenities and location")]
    public AvailableRoom[] SelectRoomPreference(
        [Description("City where you need an hotel")]
        string city,
        [Description("Date the hotel night is required")]
    DateTime dateOfBooking)
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine($"Searching for available rooms in {city} for date {dateOfBooking.ToShortDateString()}");
        Console.ResetColor();
        return availableRooms
                .Where(r => r.City.Equals(city, StringComparison.OrdinalIgnoreCase))
                .ToArray();
    }

    [KernelFunction, Description("Books a room previously selected from available rooms")]
    [return: Description("Indication if the booking was successful")]
    public bool BookSelectedRoom(
        [Description("id of the room to be booked")]
        int id)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Booking room with id {id}");
        Console.ResetColor();
        var selectedRoom = availableRooms.FirstOrDefault(r => r.RoomId == id);
        return selectedRoom != null;
    }

    [KernelFunction, Description("Provides approval from the user for making a suggested booking based on the room id")]
    [return: Description("Indication if it is allowed to make the booking")]
    public bool GetApprovalForBooking(
        [Description("id of the room to be booked")]
        int id)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Is it allowed to make the booking for room with id: {id}");
        Console.ResetColor();
        var consent = Console.ReadLine();
        return consent.Equals("yes", StringComparison.OrdinalIgnoreCase);
    }

    public class AvailableRoom
    {
        public int RoomId { get; set; }
        public string RoomType { get; set; }
        public decimal PricePerNight { get; set; }
        public string HotelName { get; set; }
        public int NumberOfAdultsAllowedInRoom { get; set; }
        public string Amenities { get; set; }
        public string City { get; set; }
    }

    private readonly AvailableRoom[] availableRooms =
    [
        // --- 50 room options below ---
        new AvailableRoom { RoomId = 304, RoomType = "Standard", PricePerNight = 110.00m, HotelName = "Harbor View", NumberOfAdultsAllowedInRoom = 2, Amenities = "Free WiFi, TV", City = "San Francisco" },
        new AvailableRoom { RoomId = 305, RoomType = "Deluxe", PricePerNight = 210.00m, HotelName = "Harbor View", NumberOfAdultsAllowedInRoom = 3, Amenities = "Free WiFi, TV, Mini Bar", City = "San Francisco" },
        new AvailableRoom { RoomId = 306, RoomType = "Suite", PricePerNight = 400.00m, HotelName = "Harbor View", NumberOfAdultsAllowedInRoom = 4, Amenities = "Free WiFi, TV, Mini Bar, Ocean View", City = "San Francisco" },
        new AvailableRoom { RoomId = 307, RoomType = "Standard", PricePerNight = 95.00m, HotelName = "Budget Stay", NumberOfAdultsAllowedInRoom = 2, Amenities = "TV, Air Conditioning", City = "Berlin" },
        new AvailableRoom { RoomId = 308, RoomType = "Deluxe", PricePerNight = 180.00m, HotelName = "Budget Stay", NumberOfAdultsAllowedInRoom = 3, Amenities = "Free WiFi, TV, Air Conditioning", City = "Berlin" },
        new AvailableRoom { RoomId = 309, RoomType = "Suite", PricePerNight = 320.00m, HotelName = "Budget Stay", NumberOfAdultsAllowedInRoom = 4, Amenities = "Free WiFi, TV, Air Conditioning, Kitchenette", City = "Seattle" },
        new AvailableRoom { RoomId = 310, RoomType = "Standard", PricePerNight = 130.00m, HotelName = "Skyline Hotel", NumberOfAdultsAllowedInRoom = 2, Amenities = "Free WiFi, TV, City View", City = "London" },
        new AvailableRoom { RoomId = 311, RoomType = "Deluxe", PricePerNight = 220.00m, HotelName = "Skyline Hotel", NumberOfAdultsAllowedInRoom = 3, Amenities = "Free WiFi, TV, Mini Bar, City View", City = "London" },
        new AvailableRoom { RoomId = 312, RoomType = "Suite", PricePerNight = 370.00m, HotelName = "Skyline Hotel", NumberOfAdultsAllowedInRoom = 4, Amenities = "Free WiFi, TV, Mini Bar, Kitchenette, City View", City = "London" },
        new AvailableRoom { RoomId = 313, RoomType = "Standard", PricePerNight = 125.00m, HotelName = "Sunset Resort", NumberOfAdultsAllowedInRoom = 2, Amenities = "Free WiFi, TV, Balcony", City = "Miami" },
        new AvailableRoom { RoomId = 314, RoomType = "Deluxe", PricePerNight = 210.00m, HotelName = "Sunset Resort", NumberOfAdultsAllowedInRoom = 3, Amenities = "Free WiFi, TV, Mini Bar, Balcony", City = "Miami" },
        new AvailableRoom { RoomId = 315, RoomType = "Suite", PricePerNight = 390.00m, HotelName = "Sunset Resort", NumberOfAdultsAllowedInRoom = 4, Amenities = "Free WiFi, TV, Mini Bar, Kitchenette, Balcony", City = "Miami" },
        new AvailableRoom { RoomId = 316, RoomType = "Standard", PricePerNight = 140.00m, HotelName = "Mountain Lodge", NumberOfAdultsAllowedInRoom = 2, Amenities = "Free WiFi, TV, Fireplace", City = "Denver" },
        new AvailableRoom { RoomId = 317, RoomType = "Deluxe", PricePerNight = 230.00m, HotelName = "Mountain Lodge", NumberOfAdultsAllowedInRoom = 3, Amenities = "Free WiFi, TV, Mini Bar, Fireplace", City = "Denver" },
        new AvailableRoom { RoomId = 318, RoomType = "Suite", PricePerNight = 410.00m, HotelName = "Mountain Lodge", NumberOfAdultsAllowedInRoom = 4, Amenities = "Free WiFi, TV, Mini Bar, Kitchenette, Fireplace", City = "Seattle" },
        new AvailableRoom { RoomId = 319, RoomType = "Standard", PricePerNight = 115.00m, HotelName = "Urban Stay", NumberOfAdultsAllowedInRoom = 2, Amenities = "Free WiFi, TV", City = "Tokyo" },
        new AvailableRoom { RoomId = 320, RoomType = "Deluxe", PricePerNight = 205.00m, HotelName = "Urban Stay", NumberOfAdultsAllowedInRoom = 3, Amenities = "Free WiFi, TV, Mini Bar", City = "Tokyo" },
        new AvailableRoom { RoomId = 321, RoomType = "Suite", PricePerNight = 360.00m, HotelName = "Urban Stay", NumberOfAdultsAllowedInRoom = 4, Amenities = "Free WiFi, TV, Mini Bar, Kitchenette", City = "Tokyo" },
        new AvailableRoom { RoomId = 322, RoomType = "Standard", PricePerNight = 100.00m, HotelName = "Seaside Inn", NumberOfAdultsAllowedInRoom = 2, Amenities = "TV, Air Conditioning", City = "Barcelona" },
        new AvailableRoom { RoomId = 323, RoomType = "Deluxe", PricePerNight = 190.00m, HotelName = "Seaside Inn", NumberOfAdultsAllowedInRoom = 3, Amenities = "Free WiFi, TV, Air Conditioning, Sea View", City = "Barcelona" },
        new AvailableRoom { RoomId = 324, RoomType = "Suite", PricePerNight = 340.00m, HotelName = "Seaside Inn", NumberOfAdultsAllowedInRoom = 4, Amenities = "Free WiFi, TV, Air Conditioning, Kitchenette, Sea View", City = "Barcelona" },
        new AvailableRoom { RoomId = 325, RoomType = "Standard", PricePerNight = 135.00m, HotelName = "Royal Palace", NumberOfAdultsAllowedInRoom = 2, Amenities = "Free WiFi, TV, Air Conditioning", City = "Rome" },
        new AvailableRoom { RoomId = 326, RoomType = "Deluxe", PricePerNight = 225.00m, HotelName = "Royal Palace", NumberOfAdultsAllowedInRoom = 3, Amenities = "Free WiFi, TV, Mini Bar, Air Conditioning", City = "Rome" },
        new AvailableRoom { RoomId = 327, RoomType = "Suite", PricePerNight = 380.00m, HotelName = "Royal Palace", NumberOfAdultsAllowedInRoom = 4, Amenities = "Free WiFi, TV, Mini Bar, Kitchenette, Air Conditioning", City = "Rome" },
        new AvailableRoom { RoomId = 328, RoomType = "Standard", PricePerNight = 105.00m, HotelName = "Airport Hotel", NumberOfAdultsAllowedInRoom = 2, Amenities = "Free WiFi, TV", City = "Frankfurt" },
        new AvailableRoom { RoomId = 329, RoomType = "Deluxe", PricePerNight = 195.00m, HotelName = "Airport Hotel", NumberOfAdultsAllowedInRoom = 3, Amenities = "Free WiFi, TV, Mini Bar", City = "Frankfurt" },
        new AvailableRoom { RoomId = 330, RoomType = "Suite", PricePerNight = 345.00m, HotelName = "Airport Hotel", NumberOfAdultsAllowedInRoom = 4, Amenities = "Free WiFi, TV, Mini Bar, Kitchenette", City = "Frankfurt" },
        new AvailableRoom { RoomId = 331, RoomType = "Standard", PricePerNight = 125.00m, HotelName = "Central Park Hotel", NumberOfAdultsAllowedInRoom = 2, Amenities = "Free WiFi, TV, Park View", City = "New York" },
        new AvailableRoom { RoomId = 332, RoomType = "Deluxe", PricePerNight = 215.00m, HotelName = "Central Park Hotel", NumberOfAdultsAllowedInRoom = 3, Amenities = "Free WiFi, TV, Mini Bar, Park View", City = "New York" },
        new AvailableRoom { RoomId = 333, RoomType = "Suite", PricePerNight = 375.00m, HotelName = "Central Park Hotel", NumberOfAdultsAllowedInRoom = 4, Amenities = "Free WiFi, TV, Mini Bar, Kitchenette, Park View", City = "New York" },
        new AvailableRoom { RoomId = 334, RoomType = "Standard", PricePerNight = 120.00m, HotelName = "Canal House", NumberOfAdultsAllowedInRoom = 2, Amenities = "Free WiFi, TV", City = "Amsterdam" },
        new AvailableRoom { RoomId = 335, RoomType = "Deluxe", PricePerNight = 210.00m, HotelName = "Canal House", NumberOfAdultsAllowedInRoom = 3, Amenities = "Free WiFi, TV, Mini Bar, Canal View", City = "Amsterdam" },
        new AvailableRoom { RoomId = 336, RoomType = "Suite", PricePerNight = 360.00m, HotelName = "Canal House", NumberOfAdultsAllowedInRoom = 4, Amenities = "Free WiFi, TV, Mini Bar, Kitchenette, Canal View", City = "Amsterdam" },
        new AvailableRoom { RoomId = 337, RoomType = "Standard", PricePerNight = 115.00m, HotelName = "Opera Hotel", NumberOfAdultsAllowedInRoom = 2, Amenities = "Free WiFi, TV", City = "Vienna" },
        new AvailableRoom { RoomId = 338, RoomType = "Deluxe", PricePerNight = 205.00m, HotelName = "Opera Hotel", NumberOfAdultsAllowedInRoom = 3, Amenities = "Free WiFi, TV, Mini Bar", City = "Vienna" },
        new AvailableRoom { RoomId = 339, RoomType = "Suite", PricePerNight = 355.00m, HotelName = "Opera Hotel", NumberOfAdultsAllowedInRoom = 4, Amenities = "Free WiFi, TV, Mini Bar, Kitchenette", City = "Seattle" },
        new AvailableRoom { RoomId = 340, RoomType = "Standard", PricePerNight = 110.00m, HotelName = "Garden Inn", NumberOfAdultsAllowedInRoom = 2, Amenities = "Free WiFi, TV, Garden View", City = "Prague" },
        new AvailableRoom { RoomId = 341, RoomType = "Deluxe", PricePerNight = 200.00m, HotelName = "Garden Inn", NumberOfAdultsAllowedInRoom = 3, Amenities = "Free WiFi, TV, Mini Bar, Garden View", City = "Prague" },
        new AvailableRoom { RoomId = 342, RoomType = "Suite", PricePerNight = 350.00m, HotelName = "Garden Inn", NumberOfAdultsAllowedInRoom = 4, Amenities = "Free WiFi, TV, Mini Bar, Kitchenette, Garden View", City = "Prague" },
        new AvailableRoom { RoomId = 343, RoomType = "Standard", PricePerNight = 108.00m, HotelName = "City Lights", NumberOfAdultsAllowedInRoom = 2, Amenities = "Free WiFi, TV", City = "Seoul" },
        new AvailableRoom { RoomId = 344, RoomType = "Deluxe", PricePerNight = 198.00m, HotelName = "City Lights", NumberOfAdultsAllowedInRoom = 3, Amenities = "Free WiFi, TV, Mini Bar", City = "Seoul" },
        new AvailableRoom { RoomId = 345, RoomType = "Suite", PricePerNight = 348.00m, HotelName = "City Lights", NumberOfAdultsAllowedInRoom = 4, Amenities = "Free WiFi, TV, Mini Bar, Kitchenette", City = "Seoul" },
        new AvailableRoom { RoomId = 346, RoomType = "Standard", PricePerNight = 112.00m, HotelName = "Lakeview Hotel", NumberOfAdultsAllowedInRoom = 2, Amenities = "Free WiFi, TV, Lake View", City = "Zurich" },
        new AvailableRoom { RoomId = 347, RoomType = "Deluxe", PricePerNight = 202.00m, HotelName = "Lakeview Hotel", NumberOfAdultsAllowedInRoom = 3, Amenities = "Free WiFi, TV, Mini Bar, Lake View", City = "Zurich" },
        new AvailableRoom { RoomId = 348, RoomType = "Suite", PricePerNight = 352.00m, HotelName = "Lakeview Hotel", NumberOfAdultsAllowedInRoom = 4, Amenities = "Free WiFi, TV, Mini Bar, Kitchenette, Lake View", City = "Zurich" },
        new AvailableRoom { RoomId = 349, RoomType = "Standard", PricePerNight = 118.00m, HotelName = "Metro Hotel", NumberOfAdultsAllowedInRoom = 2, Amenities = "Free WiFi, TV", City = "Toronto" },
        new AvailableRoom { RoomId = 350, RoomType = "Deluxe", PricePerNight = 208.00m, HotelName = "Metro Hotel", NumberOfAdultsAllowedInRoom = 3, Amenities = "Free WiFi, TV, Mini Bar", City = "Toronto" },
        new AvailableRoom { RoomId = 351, RoomType = "Suite", PricePerNight = 358.00m, HotelName = "Metro Hotel", NumberOfAdultsAllowedInRoom = 4, Amenities = "Free WiFi, TV, Mini Bar, Kitchenette", City = "Toronto" },
    ];
}
