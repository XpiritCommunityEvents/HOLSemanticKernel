using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Proxies;

namespace GloboTicket.Catalog.DbContexts
{
    public class EventCatalogDbContext : DbContext
    {
        public EventCatalogDbContext(DbContextOptions<EventCatalogDbContext> options) :
        base(options)
        {
        }
        public DbSet<Event> Events { get; set; }
        public DbSet<Venue> Venues { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure decimal precision for Price and OriginalPrice
            modelBuilder.Entity<Event>()
                .Property(e => e.Price)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Event>()
                .Property(e => e.OriginalPrice)
                .HasPrecision(10, 2);

            // Configure Event-Venue relationship
            modelBuilder.Entity<Event>()
                .HasOne(e => e.Venue)
                .WithMany(v => v.Events)
                .HasForeignKey(e => e.VenueId)
                .OnDelete(DeleteBehavior.Restrict);

            // Seed venues first
            SeedVenues(modelBuilder);

            // Original 5 events
            SeedOriginalEvents(modelBuilder);

            // Add more events - 500 additional events in batches
            SeedAdditionalEvents(modelBuilder, 0, 100);
            SeedAdditionalEvents(modelBuilder, 100, 100);
            SeedAdditionalEvents(modelBuilder, 200, 100);
            SeedAdditionalEvents(modelBuilder, 300, 100);
            SeedAdditionalEvents(modelBuilder, 400, 100);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies(); // This enables lazy loading
        }

        private void SeedOriginalEvents(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Event>().HasData(new Event
            {
                EventId = Guid.Parse("{EE272F8B-6096-4CB6-8625-BB4BB2D89E8B}"),
                Name = "John Egbert Live",
                Price = 64.99m,
                OriginalPrice = 64.99m,
                Artist = "John Egbert",
                Date = DateTime.Now.AddMonths(6),
                Description = "Join John for his farwell tour across 15 continents. John really needs no introduction since he has already mesmerized the world with his banjo.",
                ImageUrl = "/img/banjo.jpg",
                IsOnSpecialOffer = false,
                VenueId = Guid.Parse("{11111111-1111-1111-1111-111111111111}") // Madison Square Garden
            });

            modelBuilder.Entity<Event>().HasData(new Event
            {
                EventId = Guid.Parse("{3448D5A4-0F72-4DD7-BF15-C14A46B26C00}"),
                Name = "The State of Affairs: Michael Live!",
                Price = 84.99m,
                OriginalPrice = 84.99m,
                Artist = "Michael Johnson",
                Date = DateTime.Now.AddMonths(9),
                Description = "Michael Johnson doesn't need an introduction. His 25 concert across the globe last year were seen by thousands. Can we add you to the list?",
                ImageUrl = "/img/michael.jpg",
                IsOnSpecialOffer = false,
                VenueId = Guid.Parse("{11111111-1111-1111-1111-111111111112}") // Staples Center
            });

            modelBuilder.Entity<Event>().HasData(new Event
            {
                EventId = Guid.Parse("{B419A7CA-3321-4F38-BE8E-4D7B6A529319}"),
                Name = "Clash of the DJs",
                Price = 84.99m,
                OriginalPrice = 84.99m,
                Artist = "DJ 'The Mike'",
                Date = DateTime.Now.AddMonths(4),
                Description = "DJs from all over the world will compete in this epic battle for eternal fame.",
                ImageUrl = "/img/dj.jpg",
                IsOnSpecialOffer = false,
                VenueId = Guid.Parse("{11111111-1111-1111-1111-111111111113}") // United Center
            });

            modelBuilder.Entity<Event>().HasData(new Event
            {
                EventId = Guid.Parse("{62787623-4C52-43FE-B0C9-B7044FB5929B}"),
                Name = "Spanish guitar hits with Manuel",
                Price = 24.99m,
                OriginalPrice = 24.99m,
                Artist = "Manuel Santinonisi",
                Date = DateTime.Now.AddMonths(4),
                Description = "Get on the hype of Spanish Guitar concerts with Manuel.",
                ImageUrl = "/img/guitar.jpg",
                IsOnSpecialOffer = false,
                VenueId = Guid.Parse("{11111111-1111-1111-1111-111111111114}") // TD Garden
            });

            modelBuilder.Entity<Event>().HasData(new Event
            {
                EventId = Guid.Parse("{ADC42C09-08C1-4D2C-9F96-2D15BB1AF299}"),
                Name = "To the Moon and Back",
                Price = 134.99m,
                OriginalPrice = 134.99m,
                Artist = "Nick Sailor",
                Date = DateTime.Now.AddMonths(8),
                Description = "The critics are over the moon and so will you after you've watched this sing and dance extravaganza written by Nick Sailor, the man from 'My dad and sister'.",
                ImageUrl = "/img/musical.jpg",
                IsOnSpecialOffer = false,
                VenueId = Guid.Parse("{11111111-1111-1111-1111-111111111115}") // American Airlines Arena
            });
        }

        private void SeedAdditionalEvents(ModelBuilder modelBuilder, int startIndex, int count)
        {
            var random = new Random(startIndex);
            var artists = new string[]
            {
                "Taylor Swift", "Ed Sheeran", "Beyoncé", "BTS", "Drake", "Adele", "The Weeknd", "Billie Eilish",
                "Harry Styles", "Lady Gaga", "Justin Bieber", "Ariana Grande", "Post Malone", "Bruno Mars",
                "Dua Lipa", "Kendrick Lamar", "Rihanna", "Coldplay", "Imagine Dragons", "Katy Perry",
                "J Balvin", "Maroon 5", "Travis Scott", "Eminem", "Bad Bunny", "Shawn Mendes", "Camila Cabello",
                "Doja Cat", "Cardi B", "Twenty One Pilots", "Halsey", "Lewis Capaldi", "Olivia Rodrigo",
                "Lil Nas X", "The Chainsmokers", "Calvin Harris", "SZA", "Marshmello", "Lizzo", "Blackpink",
                "Daddy Yankee", "Sia", "Selena Gomez", "Jonas Brothers", "Future", "The Kid LAROI", "Megan Thee Stallion",
                "Juice WRLD", "Kygo", "Miley Cyrus", "David Guetta", "Elton John", "Khalid", "Charlie Puth",
                "Sam Smith", "Martin Garrix", "Lana Del Rey", "Niall Horan", "Ava Max", "Luke Combs", "DaBaby",
                "Lil Baby", "Jack Harlow", "Tame Impala", "Maluma", "Rosalía", "Tones and I", "Glass Animals",
                "Demi Lovato", "Alan Walker", "OneRepublic", "Zara Larsson", "KAROL G", "Lil Uzi Vert", "Tiësto",
                "Alicia Keys", "5 Seconds of Summer", "Nicki Minaj", "Little Mix", "YUNGBLUD", "Kehlani",
                "Machine Gun Kelly", "Panic! At The Disco", "Tyler, The Creator", "Bastille", "Nicky Jam",
                "Anitta", "Troye Sivan", "Mabel", "G-Eazy", "Dan + Shay", "Meghan Trainor", "NCT 127",
                "Avicii", "Fall Out Boy", "SEVENTEEN", "Robin Schulz", "Jason Derulo", "Offset", "Anne-Marie",
                "Zedd", "Young Thug", "Lauv", "James Arthur", "BLACKPINK ROSÉ", "Madison Beer", "LISA", "The Script"
            };

            var tourNames = new string[]
            {
                "World Tour", "Live in Concert", "Reunion Tour", "Greatest Hits Tour", "The Experience",
                "Summer Festival", "Unplugged", "Live at Home", "The Sessions", "Acoustic Night",
                "Stadium Tour", "Farewell Tour", "Comeback Tour", "Anniversary Tour", "Legends Tour"
            };

            var descriptions = new string[]
            {
                "An unforgettable night with {0} showcasing their greatest hits and fan favorites. Don't miss this chance to see one of the most iconic performers of our time.",
                "Experience the magic of {0} in this once-in-a-lifetime concert event. With stunning visuals and incredible sound, this is a show you'll remember forever.",
                "Join {0} for an intimate evening of music and storytelling. This special event brings fans closer than ever to their favorite artist.",
                "{0} returns to the stage with a spectacular new show featuring their latest album and classic favorites. A must-see for true fans!",
                "The electrifying {0} brings their high-energy performance to town with special guests and surprises throughout the night."
            };

            var images = new string[]
            {
                "/img/banjo.jpg",
                "/img/michael.jpg",
                "/img/dj.jpg",
                "/img/guitar.jpg",
                "/img/musical.jpg"
            };

            for (int i = 0; i < count; i++)
            {
                int index = startIndex + i;
                int artistIndex = index % artists.Length;
                string artist = artists[artistIndex];
                
                if (index > artists.Length)
                {
                    int secondIndex = (index / artists.Length) % artists.Length;
                    if (secondIndex != artistIndex)
                    {
                        artist = $"{artists[artistIndex]} & {artists[secondIndex]}";
                    }
                }

                var tourName = tourNames[index % tourNames.Length];
                var eventName = $"{artist}: {tourName}";
                var description = string.Format(descriptions[index % descriptions.Length], artist);
                var imageUrl = images[index % images.Length];
                
                // Calculate base price using modulo operation (20, 30, 40, etc.)
                var basePrice = 20 + ((index % 19) * 10);
                // Convert to psychological price (e.g., 19.99, 29.99, 39.99)
                var price = basePrice - 0.01m;
                
                var date = DateTime.Now.AddDays(30 + (index * 3));
                
                // Assign venue ID - cycle through the 90 venues we created (index 0-89 maps to venues 111111111111...111111111200)
                var venueIndex = index % 90;
                var venueId = Guid.Parse($"{{11111111-1111-1111-1111-{111111111111L + venueIndex:D12}}}");

                modelBuilder.Entity<Event>().HasData(new Event
                {
                    EventId = Guid.NewGuid(),
                    Name = eventName,
                    Price = price,
                    OriginalPrice = price,
                    Artist = artist,
                    Date = date,
                    Description = description,
                    ImageUrl = imageUrl,
                    IsOnSpecialOffer = false,
                    VenueId = venueId
                });
            }
        }

        private void SeedVenues(ModelBuilder modelBuilder)
        {
            var venues = new List<Venue>
            {
                // Major Arena/Stadium Venues
                new Venue { VenueId = Guid.Parse("{11111111-1111-1111-1111-111111111111}"), Name = "Madison Square Garden", SeatsAvailable = 20000, Address = "4 Pennsylvania Plaza", City = "New York", State = "NY", ZipCode = "10001" },
                new Venue { VenueId = Guid.Parse("{11111111-1111-1111-1111-111111111112}"), Name = "Staples Center", SeatsAvailable = 21000, Address = "1111 S Figueroa St", City = "Los Angeles", State = "CA", ZipCode = "90015" },
                new Venue { VenueId = Guid.Parse("{11111111-1111-1111-1111-111111111113}"), Name = "United Center", SeatsAvailable = 23500, Address = "1901 W Madison St", City = "Chicago", State = "IL", ZipCode = "60612" },
                new Venue { VenueId = Guid.Parse("{11111111-1111-1111-1111-111111111114}"), Name = "TD Garden", SeatsAvailable = 19580, Address = "100 Legends Way", City = "Boston", State = "MA", ZipCode = "02114" },
                new Venue { VenueId = Guid.Parse("{11111111-1111-1111-1111-111111111115}"), Name = "American Airlines Arena", SeatsAvailable = 19600, Address = "601 Biscayne Blvd", City = "Miami", State = "FL", ZipCode = "33132" },

                // Theater Venues
                new Venue { VenueId = Guid.Parse("{11111111-1111-1111-1111-111111111116}"), Name = "Radio City Music Hall", SeatsAvailable = 6015, Address = "1260 6th Ave", City = "New York", State = "NY", ZipCode = "10020" },
                new Venue { VenueId = Guid.Parse("{11111111-1111-1111-1111-111111111117}"), Name = "Hollywood Bowl", SeatsAvailable = 17500, Address = "2301 N Highland Ave", City = "Los Angeles", State = "CA", ZipCode = "90068" },
                new Venue { VenueId = Guid.Parse("{11111111-1111-1111-1111-111111111118}"), Name = "Red Rocks Amphitheatre", SeatsAvailable = 9525, Address = "18300 W Alameda Pkwy", City = "Morrison", State = "CO", ZipCode = "80465" },
                new Venue { VenueId = Guid.Parse("{11111111-1111-1111-1111-111111111119}"), Name = "The Greek Theatre", SeatsAvailable = 5900, Address = "2700 N Vermont Ave", City = "Los Angeles", State = "CA", ZipCode = "90027" },
                new Venue { VenueId = Guid.Parse("{11111111-1111-1111-1111-111111111120}"), Name = "Carnegie Hall", SeatsAvailable = 2804, Address = "881 7th Ave", City = "New York", State = "NY", ZipCode = "10019" },

                // Concert Halls
                new Venue { VenueId = Guid.Parse("{11111111-1111-1111-1111-111111111121}"), Name = "House of Blues Chicago", SeatsAvailable = 1800, Address = "329 N Dearborn St", City = "Chicago", State = "IL", ZipCode = "60654" },
                new Venue { VenueId = Guid.Parse("{11111111-1111-1111-1111-111111111122}"), Name = "The Fillmore", SeatsAvailable = 1150, Address = "1805 Geary Blvd", City = "San Francisco", State = "CA", ZipCode = "94115" },
                new Venue { VenueId = Guid.Parse("{11111111-1111-1111-1111-111111111123}"), Name = "The Ryman Auditorium", SeatsAvailable = 2362, Address = "116 5th Ave N", City = "Nashville", State = "TN", ZipCode = "37219" },
                new Venue { VenueId = Guid.Parse("{11111111-1111-1111-1111-111111111124}"), Name = "The Apollo Theater", SeatsAvailable = 1506, Address = "253 W 125th St", City = "New York", State = "NY", ZipCode = "10027" },
                new Venue { VenueId = Guid.Parse("{11111111-1111-1111-1111-111111111125}"), Name = "The Beacon Theatre", SeatsAvailable = 2894, Address = "2124 Broadway", City = "New York", State = "NY", ZipCode = "10023" },

                // Stadium Venues
                new Venue { VenueId = Guid.Parse("{11111111-1111-1111-1111-111111111126}"), Name = "MetLife Stadium", SeatsAvailable = 82500, Address = "1 MetLife Stadium Dr", City = "East Rutherford", State = "NJ", ZipCode = "07073" },
                new Venue { VenueId = Guid.Parse("{11111111-1111-1111-1111-111111111127}"), Name = "AT&T Stadium", SeatsAvailable = 80000, Address = "1 AT&T Way", City = "Arlington", State = "TX", ZipCode = "76011" },
                new Venue { VenueId = Guid.Parse("{11111111-1111-1111-1111-111111111128}"), Name = "Mercedes-Benz Stadium", SeatsAvailable = 71000, Address = "1 AMB Dr NW", City = "Atlanta", State = "GA", ZipCode = "30313" },
                new Venue { VenueId = Guid.Parse("{11111111-1111-1111-1111-111111111129}"), Name = "Soldier Field", SeatsAvailable = 61500, Address = "1410 Museum Campus Dr", City = "Chicago", State = "IL", ZipCode = "60605" },
                new Venue { VenueId = Guid.Parse("{11111111-1111-1111-1111-111111111130}"), Name = "Rose Bowl", SeatsAvailable = 88565, Address = "1001 Rose Bowl Dr", City = "Pasadena", State = "CA", ZipCode = "91103" },

                // Music Venues by City
                new Venue { VenueId = Guid.Parse("{11111111-1111-1111-1111-111111111131}"), Name = "The Troubadour", SeatsAvailable = 400, Address = "9081 Santa Monica Blvd", City = "West Hollywood", State = "CA", ZipCode = "90069" },
                new Venue { VenueId = Guid.Parse("{11111111-1111-1111-1111-111111111132}"), Name = "9:30 Club", SeatsAvailable = 1200, Address = "815 V St NW", City = "Washington", State = "DC", ZipCode = "20001" },
                new Venue { VenueId = Guid.Parse("{11111111-1111-1111-1111-111111111133}"), Name = "First Avenue", SeatsAvailable = 1550, Address = "701 1st Ave N", City = "Minneapolis", State = "MN", ZipCode = "55403" },
                new Venue { VenueId = Guid.Parse("{11111111-1111-1111-1111-111111111134}"), Name = "The Tabernacle", SeatsAvailable = 2600, Address = "152 Luckie St NW", City = "Atlanta", State = "GA", ZipCode = "30303" },
                new Venue { VenueId = Guid.Parse("{11111111-1111-1111-1111-111111111135}"), Name = "The Warfield", SeatsAvailable = 2300, Address = "982 Market St", City = "San Francisco", State = "CA", ZipCode = "94102" },

                // More Arenas
                new Venue { VenueId = Guid.Parse("{11111111-1111-1111-1111-111111111136}"), Name = "Pepsi Center", SeatsAvailable = 20000, Address = "1000 Chopper Cir", City = "Denver", State = "CO", ZipCode = "80204" },
                new Venue { VenueId = Guid.Parse("{11111111-1111-1111-1111-111111111137}"), Name = "KeyArena", SeatsAvailable = 17072, Address = "305 Harrison St", City = "Seattle", State = "WA", ZipCode = "98109" },
                new Venue { VenueId = Guid.Parse("{11111111-1111-1111-1111-111111111138}"), Name = "Oracle Arena", SeatsAvailable = 19596, Address = "7000 Coliseum Way", City = "Oakland", State = "CA", ZipCode = "94621" },
                new Venue { VenueId = Guid.Parse("{11111111-1111-1111-1111-111111111139}"), Name = "AmericanAirlines Center", SeatsAvailable = 20000, Address = "2500 Victory Ave", City = "Dallas", State = "TX", ZipCode = "75219" },
                new Venue { VenueId = Guid.Parse("{11111111-1111-1111-1111-111111111140}"), Name = "Little Caesars Arena", SeatsAvailable = 20332, Address = "2645 Woodward Ave", City = "Detroit", State = "MI", ZipCode = "48201" },

                // Amphitheatres
                new Venue { VenueId = Guid.Parse("{11111111-1111-1111-1111-111111111141}"), Name = "Shoreline Amphitheatre", SeatsAvailable = 22500, Address = "1 Amphitheatre Pkwy", City = "Mountain View", State = "CA", ZipCode = "94043" },
                new Venue { VenueId = Guid.Parse("{11111111-1111-1111-1111-111111111142}"), Name = "Jones Beach Theater", SeatsAvailable = 15000, Address = "1000 Ocean Pkwy", City = "Wantagh", State = "NY", ZipCode = "11793" },
                new Venue { VenueId = Guid.Parse("{11111111-1111-1111-1111-111111111143}"), Name = "PNC Music Pavilion", SeatsAvailable = 20000, Address = "707 Pavilion Blvd", City = "Charlotte", State = "NC", ZipCode = "28217" },
                new Venue { VenueId = Guid.Parse("{11111111-1111-1111-1111-111111111144}"), Name = "Cynthia Woods Mitchell Pavilion", SeatsAvailable = 16500, Address = "2005 Lake Robbins Dr", City = "The Woodlands", State = "TX", ZipCode = "77380" },
                new Venue { VenueId = Guid.Parse("{11111111-1111-1111-1111-111111111145}"), Name = "Riverbend Music Center", SeatsAvailable = 20500, Address = "6295 Kellogg Ave", City = "Cincinnati", State = "OH", ZipCode = "45230" },

                // Historic Venues
                new Venue { VenueId = Guid.Parse("{11111111-1111-1111-1111-111111111146}"), Name = "Grand Ole Opry", SeatsAvailable = 4372, Address = "2804 Opryland Dr", City = "Nashville", State = "TN", ZipCode = "37214" },
                new Venue { VenueId = Guid.Parse("{11111111-1111-1111-1111-111111111147}"), Name = "The Chicago Theatre", SeatsAvailable = 3600, Address = "175 N State St", City = "Chicago", State = "IL", ZipCode = "60601" },
                new Venue { VenueId = Guid.Parse("{11111111-1111-1111-1111-111111111148}"), Name = "Fox Theatre Atlanta", SeatsAvailable = 4665, Address = "660 Peachtree St NE", City = "Atlanta", State = "GA", ZipCode = "30308" },
                new Venue { VenueId = Guid.Parse("{11111111-1111-1111-1111-111111111149}"), Name = "The Orpheum Theatre", SeatsAvailable = 2308, Address = "203 S Main St", City = "Memphis", State = "TN", ZipCode = "38103" },
                new Venue { VenueId = Guid.Parse("{11111111-1111-1111-1111-111111111150}"), Name = "Palace Theatre", SeatsAvailable = 1743, Address = "1564 Broadway", City = "New York", State = "NY", ZipCode = "10036" },

                // More Concert Halls
                new Venue { VenueId = Guid.Parse("{11111111-1111-1111-1111-111111111151}"), Name = "The Wiltern", SeatsAvailable = 1850, Address = "3790 Wilshire Blvd", City = "Los Angeles", State = "CA", ZipCode = "90010" },
                new Venue { VenueId = Guid.Parse("{11111111-1111-1111-1111-111111111152}"), Name = "Terminal 5", SeatsAvailable = 3000, Address = "610 W 56th St", City = "New York", State = "NY", ZipCode = "10019" },
                new Venue { VenueId = Guid.Parse("{11111111-1111-1111-1111-111111111153}"), Name = "The Anthem", SeatsAvailable = 6000, Address = "901 Wharf St SW", City = "Washington", State = "DC", ZipCode = "20024" },
                new Venue { VenueId = Guid.Parse("{11111111-1111-1111-1111-111111111154}"), Name = "House of Blues Las Vegas", SeatsAvailable = 1800, Address = "3950 Las Vegas Blvd S", City = "Las Vegas", State = "NV", ZipCode = "89119" },
                new Venue { VenueId = Guid.Parse("{11111111-1111-1111-1111-111111111155}"), Name = "The Masonic", SeatsAvailable = 3200, Address = "1111 California St", City = "San Francisco", State = "CA", ZipCode = "94108" },

                // Festival Venues
                new Venue { VenueId = Guid.Parse("{11111111-1111-1111-1111-111111111156}"), Name = "Coachella Valley Music Festival", SeatsAvailable = 99000, Address = "81800 51st Ave", City = "Indio", State = "CA", ZipCode = "92201" },
                new Venue { VenueId = Guid.Parse("{11111111-1111-1111-1111-111111111157}"), Name = "Bonnaroo Music Festival", SeatsAvailable = 80000, Address = "4365 Bushy Branch Rd", City = "Manchester", State = "TN", ZipCode = "37355" },
                new Venue { VenueId = Guid.Parse("{11111111-1111-1111-1111-111111111158}"), Name = "Lollapalooza Grant Park", SeatsAvailable = 100000, Address = "337 E Randolph St", City = "Chicago", State = "IL", ZipCode = "60601" },
                new Venue { VenueId = Guid.Parse("{11111111-1111-1111-1111-111111111159}"), Name = "Austin City Limits Festival", SeatsAvailable = 75000, Address = "2100 Barton Springs Rd", City = "Austin", State = "TX", ZipCode = "78746" },
                new Venue { VenueId = Guid.Parse("{11111111-1111-1111-1111-111111111160}"), Name = "Electric Daisy Carnival", SeatsAvailable = 400000, Address = "7000 Las Vegas Blvd N", City = "Las Vegas", State = "NV", ZipCode = "89115" },

                // Medium Venues
                new Venue { VenueId = Guid.Parse("{11111111-1111-1111-1111-111111111161}"), Name = "The Observatory", SeatsAvailable = 1500, Address = "2661 State St", City = "Santa Ana", State = "CA", ZipCode = "92706" },
                new Venue { VenueId = Guid.Parse("{11111111-1111-1111-1111-111111111162}"), Name = "The Rave", SeatsAvailable = 2500, Address = "2401 W Wisconsin Ave", City = "Milwaukee", State = "WI", ZipCode = "53233" },
                new Venue { VenueId = Guid.Parse("{11111111-1111-1111-1111-111111111163}"), Name = "The National", SeatsAvailable = 1500, Address = "708 E Broad St", City = "Richmond", State = "VA", ZipCode = "23219" },
                new Venue { VenueId = Guid.Parse("{11111111-1111-1111-1111-111111111164}"), Name = "Vinyl Music Hall", SeatsAvailable = 2000, Address = "2 S Palafox St", City = "Pensacola", State = "FL", ZipCode = "32502" },
                new Venue { VenueId = Guid.Parse("{11111111-1111-1111-1111-111111111165}"), Name = "The Orange Peel", SeatsAvailable = 1050, Address = "101 Biltmore Ave", City = "Asheville", State = "NC", ZipCode = "28801" },

                // Club Venues
                new Venue { VenueId = Guid.Parse("{11111111-1111-1111-1111-111111111166}"), Name = "The Viper Room", SeatsAvailable = 250, Address = "8852 Sunset Blvd", City = "West Hollywood", State = "CA", ZipCode = "90069" },
                new Venue { VenueId = Guid.Parse("{11111111-1111-1111-1111-111111111167}"), Name = "The Bowery Ballroom", SeatsAvailable = 575, Address = "6 Delancey St", City = "New York", State = "NY", ZipCode = "10002" },
                new Venue { VenueId = Guid.Parse("{11111111-1111-1111-1111-111111111168}"), Name = "The Mercury Lounge", SeatsAvailable = 250, Address = "217 E Houston St", City = "New York", State = "NY", ZipCode = "10002" },
                new Venue { VenueId = Guid.Parse("{11111111-1111-1111-1111-111111111169}"), Name = "The Crocodile", SeatsAvailable = 400, Address = "2200 2nd Ave", City = "Seattle", State = "WA", ZipCode = "98121" },
                new Venue { VenueId = Guid.Parse("{11111111-1111-1111-1111-111111111170}"), Name = "The Garage", SeatsAvailable = 600, Address = "2130 N Cahuenga Blvd", City = "Los Angeles", State = "CA", ZipCode = "90068" },

                // Outdoor Venues
                new Venue { VenueId = Guid.Parse("{11111111-1111-1111-1111-111111111171}"), Name = "Central Park SummerStage", SeatsAvailable = 5000, Address = "830 5th Ave", City = "New York", State = "NY", ZipCode = "10065" },
                new Venue { VenueId = Guid.Parse("{11111111-1111-1111-1111-111111111172}"), Name = "Millennium Park", SeatsAvailable = 11000, Address = "201 E Randolph St", City = "Chicago", State = "IL", ZipCode = "60602" },
                new Venue { VenueId = Guid.Parse("{11111111-1111-1111-1111-111111111173}"), Name = "Pier 97 at Hudson River Park", SeatsAvailable = 5000, Address = "West 57th St & 12th Ave", City = "New York", State = "NY", ZipCode = "10019" },
                new Venue { VenueId = Guid.Parse("{11111111-1111-1111-1111-111111111174}"), Name = "Edgefield", SeatsAvailable = 4000, Address = "2126 SW Halsey St", City = "Troutdale", State = "OR", ZipCode = "97060" },
                new Venue { VenueId = Guid.Parse("{11111111-1111-1111-1111-111111111175}"), Name = "Red Hat Amphitheater", SeatsAvailable = 5500, Address = "500 S McDowell St", City = "Raleigh", State = "NC", ZipCode = "27601" },

                // Arena continued
                new Venue { VenueId = Guid.Parse("{11111111-1111-1111-1111-111111111176}"), Name = "Moda Center", SeatsAvailable = 19980, Address = "1 N Center Ct St", City = "Portland", State = "OR", ZipCode = "97227" },
                new Venue { VenueId = Guid.Parse("{11111111-1111-1111-1111-111111111177}"), Name = "Vivint Smart Home Arena", SeatsAvailable = 18306, Address = "301 W South Temple", City = "Salt Lake City", State = "UT", ZipCode = "84101" },
                new Venue { VenueId = Guid.Parse("{11111111-1111-1111-1111-111111111178}"), Name = "Talking Stick Resort Arena", SeatsAvailable = 18422, Address = "201 E Jefferson St", City = "Phoenix", State = "AZ", ZipCode = "85004" },
                new Venue { VenueId = Guid.Parse("{11111111-1111-1111-1111-111111111179}"), Name = "Target Center", SeatsAvailable = 19356, Address = "600 1st Ave N", City = "Minneapolis", State = "MN", ZipCode = "55403" },
                new Venue { VenueId = Guid.Parse("{11111111-1111-1111-1111-111111111180}"), Name = "T-Mobile Arena", SeatsAvailable = 20000, Address = "3780 Las Vegas Blvd S", City = "Las Vegas", State = "NV", ZipCode = "89158" },

                // More Club/Theater Venues
                new Venue { VenueId = Guid.Parse("{11111111-1111-1111-1111-111111111181}"), Name = "The Crystal Ballroom", SeatsAvailable = 1500, Address = "1332 W Burnside St", City = "Portland", State = "OR", ZipCode = "97209" },
                new Venue { VenueId = Guid.Parse("{11111111-1111-1111-1111-111111111182}"), Name = "The Metro", SeatsAvailable = 1100, Address = "3730 N Clark St", City = "Chicago", State = "IL", ZipCode = "60613" },
                new Venue { VenueId = Guid.Parse("{11111111-1111-1111-1111-111111111183}"), Name = "The Showbox", SeatsAvailable = 1200, Address = "1426 1st Ave", City = "Seattle", State = "WA", ZipCode = "98101" },
                new Venue { VenueId = Guid.Parse("{11111111-1111-1111-1111-111111111184}"), Name = "The Ogden Theatre", SeatsAvailable = 1600, Address = "935 E Colfax Ave", City = "Denver", State = "CO", ZipCode = "80218" },
                new Venue { VenueId = Guid.Parse("{11111111-1111-1111-1111-111111111185}"), Name = "The Pageant", SeatsAvailable = 2300, Address = "6161 Delmar Blvd", City = "St. Louis", State = "MO", ZipCode = "63112" },

                // Smaller intimate venues
                new Venue { VenueId = Guid.Parse("{11111111-1111-1111-1111-111111111186}"), Name = "The Blue Note", SeatsAvailable = 300, Address = "131 W 3rd St", City = "New York", State = "NY", ZipCode = "10012" },
                new Venue { VenueId = Guid.Parse("{11111111-1111-1111-1111-111111111187}"), Name = "The Basement East", SeatsAvailable = 500, Address = "917 Woodland St", City = "Nashville", State = "TN", ZipCode = "37206" },
                new Venue { VenueId = Guid.Parse("{11111111-1111-1111-1111-111111111188}"), Name = "Antone's", SeatsAvailable = 800, Address = "305 E 5th St", City = "Austin", State = "TX", ZipCode = "78701" },
                new Venue { VenueId = Guid.Parse("{11111111-1111-1111-1111-111111111189}"), Name = "The Trocadero", SeatsAvailable = 1200, Address = "1003 Arch St", City = "Philadelphia", State = "PA", ZipCode = "19107" },
                new Venue { VenueId = Guid.Parse("{11111111-1111-1111-1111-111111111190}"), Name = "The Paradise Rock Club", SeatsAvailable = 933, Address = "967 Commonwealth Ave", City = "Boston", State = "MA", ZipCode = "02215" },

                // Additional major venues to reach 100
                new Venue { VenueId = Guid.Parse("{11111111-1111-1111-1111-111111111191}"), Name = "Wells Fargo Center", SeatsAvailable = 21000, Address = "3601 S Broad St", City = "Philadelphia", State = "PA", ZipCode = "19148" },
                new Venue { VenueId = Guid.Parse("{11111111-1111-1111-1111-111111111192}"), Name = "Amway Center", SeatsAvailable = 18846, Address = "400 W Church St", City = "Orlando", State = "FL", ZipCode = "32801" },
                new Venue { VenueId = Guid.Parse("{11111111-1111-1111-1111-111111111193}"), Name = "Prudential Center", SeatsAvailable = 17625, Address = "25 Lafayette St", City = "Newark", State = "NJ", ZipCode = "07102" },
                new Venue { VenueId = Guid.Parse("{11111111-1111-1111-1111-111111111194}"), Name = "Smoothie King Center", SeatsAvailable = 16867, Address = "1501 Dave Dixon Dr", City = "New Orleans", State = "LA", ZipCode = "70113" },
                new Venue { VenueId = Guid.Parse("{11111111-1111-1111-1111-111111111195}"), Name = "Scotiabank Arena", SeatsAvailable = 19800, Address = "40 Bay St", City = "Toronto", State = "ON", ZipCode = "M5J 2X2" },
                new Venue { VenueId = Guid.Parse("{11111111-1111-1111-1111-111111111196}"), Name = "KeyBank Center", SeatsAvailable = 19070, Address = "1 Seymour H Knox III Plaza", City = "Buffalo", State = "NY", ZipCode = "14203" },
                new Venue { VenueId = Guid.Parse("{11111111-1111-1111-1111-111111111197}"), Name = "Enterprise Center", SeatsAvailable = 19150, Address = "1401 Clark Ave", City = "St. Louis", State = "MO", ZipCode = "63103" },
                new Venue { VenueId = Guid.Parse("{11111111-1111-1111-1111-111111111198}"), Name = "FedExForum", SeatsAvailable = 18119, Address = "191 Beale St", City = "Memphis", State = "TN", ZipCode = "38103" },
                new Venue { VenueId = Guid.Parse("{11111111-1111-1111-1111-111111111199}"), Name = "Gila River Arena", SeatsAvailable = 17125, Address = "9400 W Maryland Ave", City = "Glendale", State = "AZ", ZipCode = "85305" },
                new Venue { VenueId = Guid.Parse("{11111111-1111-1111-1111-111111111200}"), Name = "BOK Center", SeatsAvailable = 19199, Address = "200 S Denver Ave", City = "Tulsa", State = "OK", ZipCode = "74103" }
            };

            foreach (var venue in venues)
            {
                modelBuilder.Entity<Venue>().HasData(venue);
            }
        }
    }
}