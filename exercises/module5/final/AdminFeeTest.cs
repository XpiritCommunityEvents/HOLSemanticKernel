using Microsoft.VisualStudio.TestTools.UnitTesting;
using GloboTicket.Frontend.Services;
using GloboTicket.Frontend.Models;
using GloboTicket.Frontend.Models.Api;
using System;
using System.Threading.Tasks;

namespace AdminFeeTests
{
    [TestClass]
    public class AdminFeeTest
    {
        private InMemoryShoppingBasketService basketService;
        private Settings settings;

        [TestInitialize]
        public void Setup()
        {
            settings = new Settings();
            
            // Mock event catalog service that returns a simple event
            var mockEventCatalogService = new MockEventCatalogService();
            basketService = new InMemoryShoppingBasketService(settings, mockEventCatalogService);
        }

        [TestMethod]
        public async Task AdminFee_ShouldBeApplied_WhenTotalIsBelow500()
        {
            // Arrange
            var basketId = Guid.NewGuid();
            var basketLine = new BasketLineForCreation
            {
                EventId = Guid.NewGuid(),
                TicketAmount = 1,
                Price = 489.91m // This is the problematic amount mentioned in the issue
            };

            // Act
            await basketService.AddToBasket(basketId, basketLine);
            bool shouldApplyAdminCost = await basketService.ShouldApplyAdministrationCost(basketId);
            decimal adminCost = await basketService.CalculateAdministrationCost(basketId);

            // Assert
            Assert.IsTrue(shouldApplyAdminCost, "Administration fee should be applied for total of $489.91");
            Assert.AreEqual(24.50m, adminCost, 0.01m, "Administration fee should be 5% of $489.91 = $24.50");
        }

        [TestMethod]
        public async Task AdminFee_ShouldNotBeApplied_WhenTotalIsExactly500()
        {
            // Arrange
            var basketId = Guid.NewGuid();
            var basketLine = new BasketLineForCreation
            {
                EventId = Guid.NewGuid(),
                TicketAmount = 1,
                Price = 500.00m
            };

            // Act
            await basketService.AddToBasket(basketId, basketLine);
            bool shouldApplyAdminCost = await basketService.ShouldApplyAdministrationCost(basketId);
            decimal adminCost = await basketService.CalculateAdministrationCost(basketId);

            // Assert
            Assert.IsFalse(shouldApplyAdminCost, "Administration fee should NOT be applied for total of exactly $500.00");
            Assert.AreEqual(0m, adminCost, "Administration fee should be $0 for total of $500.00");
        }

        [TestMethod]
        public async Task AdminFee_ShouldNotBeApplied_WhenTotalIsAbove500()
        {
            // Arrange
            var basketId = Guid.NewGuid();
            var basketLine = new BasketLineForCreation
            {
                EventId = Guid.NewGuid(),
                TicketAmount = 1,
                Price = 500.01m
            };

            // Act
            await basketService.AddToBasket(basketId, basketLine);
            bool shouldApplyAdminCost = await basketService.ShouldApplyAdministrationCost(basketId);
            decimal adminCost = await basketService.CalculateAdministrationCost(basketId);

            // Assert
            Assert.IsFalse(shouldApplyAdminCost, "Administration fee should NOT be applied for total above $500");
            Assert.AreEqual(0m, adminCost, "Administration fee should be $0 for total above $500");
        }

        [TestMethod]
        public async Task AdminFee_EdgeCase_499_99()
        {
            // Arrange
            var basketId = Guid.NewGuid();
            var basketLine = new BasketLineForCreation
            {
                EventId = Guid.NewGuid(),
                TicketAmount = 1,
                Price = 499.99m
            };

            // Act
            await basketService.AddToBasket(basketId, basketLine);
            bool shouldApplyAdminCost = await basketService.ShouldApplyAdministrationCost(basketId);
            decimal adminCost = await basketService.CalculateAdministrationCost(basketId);

            // Assert
            Assert.IsTrue(shouldApplyAdminCost, "Administration fee should be applied for total of $499.99");
            Assert.AreEqual(25.00m, adminCost, 0.01m, "Administration fee should be 5% of $499.99 = $25.00");
        }
    }

    // Mock implementation for testing
    public class MockEventCatalogService : IEventCatalogService
    {
        public Task<Event> GetEvent(Guid eventId)
        {
            return Task.FromResult(new Event
            {
                EventId = eventId,
                Name = "Test Event",
                Date = DateTime.Now.AddDays(30),
                VenueName = "Test Venue",
                VenueCity = "Test City",
                VenueState = "Test State",
                IsOnSpecialOffer = false,
                OriginalPrice = 0
            });
        }

        public Task<IEnumerable<Event>> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
