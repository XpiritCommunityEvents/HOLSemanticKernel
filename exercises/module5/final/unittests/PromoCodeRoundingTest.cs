using Microsoft.VisualStudio.TestTools.UnitTesting;
using GloboTicket.Frontend.Services;
using GloboTicket.Frontend.Models;
using GloboTicket.Frontend.Models.Api;
using System;
using System.Threading.Tasks;

namespace unittests
{
    [TestClass]
    public class PromoCodeRoundingTest
    {
        private InMemoryShoppingBasketService basketService = null!;
        private Settings settings = null!;

        [TestInitialize]
        public void Setup()
        {
            settings = new Settings();
            var mockEventCatalogService = new MockEventCatalogService();
            basketService = new InMemoryShoppingBasketService(settings, mockEventCatalogService);
        }

        [TestMethod]
        public async Task PromoCode_ShouldRoundProperly_NotTruncate()
        {
            // Test case where Math.Truncate and Math.Round produce different results
            // Price: $10.055, 10% discount = $9.0495
            // Math.Truncate: $9.04, Math.Round: $9.05 (correct)
            
            // Arrange
            var basketId = Guid.NewGuid();
            var basketLine = new BasketLineForCreation
            {
                EventId = Guid.NewGuid(),
                TicketAmount = 1,
                Price = 10.055m
            };

            // Act
            var addedLine = await basketService.AddToBasket(basketId, basketLine);
            await basketService.ApplyPromoCode(addedLine.BasketId, "SAVE10"); // 10% discount
            
            decimal totalWithoutPromo = await basketService.GetTotalPrice(addedLine.BasketId, applyPromoCode: false);
            decimal totalWithPromo = await basketService.GetTotalPrice(addedLine.BasketId, applyPromoCode: true);
            
            // Calculate expected values
            decimal originalPrice = 10.055m;
            decimal discountedPrice = originalPrice * 0.9m; // 9.0495
            decimal expectedRounded = Math.Round(discountedPrice, 2); // 9.05
            decimal incorrectTruncated = Math.Truncate(discountedPrice * 100) / 100; // 9.04
            
            // Since this is below $500, admin fee applies (5%)
            decimal expectedTotalWithRounding = expectedRounded + Math.Round(expectedRounded * 0.05m, 2);
            decimal incorrectTotalWithTruncation = incorrectTruncated + Math.Round(incorrectTruncated * 0.05m, 2);
            
            // Assert
            Assert.AreEqual(9.05m, expectedRounded, "Expected rounded subtotal should be 9.05");
            Assert.AreEqual(9.04m, incorrectTruncated, "Truncated subtotal should be 9.04"); 
            Assert.AreNotEqual(incorrectTotalWithTruncation, totalWithPromo, 
                "Total should not match the incorrectly truncated calculation");
            
            // The promo code should result in proper rounding, not truncation
            // Expected: 9.05 + 5% admin fee = 9.05 + 0.45 = 9.50
            Assert.AreEqual(9.50m, expectedTotalWithRounding, "Expected total with proper rounding should be 9.50");
            Assert.AreEqual(expectedTotalWithRounding, totalWithPromo, 
                "Total should use proper rounding (9.50), not truncation");
        }
    }
}