using Microsoft.VisualStudio.TestTools.UnitTesting;
using GloboTicket.Frontend.Services;
using GloboTicket.Frontend.Models;
using GloboTicket.Frontend.Models.Api;
using System;
using System.Threading.Tasks;

namespace unittests
{
    [TestClass]
    public class FloatingPointPrecisionTest
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
        public async Task AdminFee_FloatingPointEdgeCase_499_999999()
        {
            // This test verifies the exact floating-point precision issue described in the issue
            // Where 499.999999m with float casting would incorrectly round to 500.0f 
            // but with decimal comparison stays correctly below 500.0m
            
            // Arrange
            var basketId = Guid.NewGuid();
            var basketLine = new BasketLineForCreation
            {
                EventId = Guid.NewGuid(),
                TicketAmount = 1,
                Price = 499.999999m
            };

            // Act
            var addedLine = await basketService.AddToBasket(basketId, basketLine);
            bool shouldApplyAdminCost = await basketService.ShouldApplyAdministrationCost(addedLine.BasketId);
            decimal adminCost = await basketService.CalculateAdministrationCost(addedLine.BasketId);

            // Verify what would happen with float vs decimal
            decimal testValue = 499.999999m;
            bool decimalComparison = testValue < 500.0m;       // Should be True
            bool floatComparison = (float)testValue < 500.0f;  // Would be False due to precision loss

            // Assert
            Assert.IsTrue(decimalComparison, "Decimal comparison should correctly identify 499.999999 < 500");
            Assert.IsFalse(floatComparison, "Float comparison incorrectly rounds 499.999999 to 500.0f");
            Assert.IsTrue(shouldApplyAdminCost, 
                "Administration fee should be applied for 499.999999 (using decimal precision)");
            Assert.AreEqual(25.00m, adminCost, 0.01m, 
                "Administration fee should be 5% of 499.999999 ≈ $25.00");
        }

        [TestMethod]
        public async Task AdminFee_PreciseThreshold_500_000001()
        {
            // Test value just above the threshold to ensure no admin fee
            
            // Arrange
            var basketId = Guid.NewGuid();
            var basketLine = new BasketLineForCreation
            {
                EventId = Guid.NewGuid(),
                TicketAmount = 1,
                Price = 500.000001m
            };

            // Act
            var addedLine = await basketService.AddToBasket(basketId, basketLine);
            bool shouldApplyAdminCost = await basketService.ShouldApplyAdministrationCost(addedLine.BasketId);
            decimal adminCost = await basketService.CalculateAdministrationCost(addedLine.BasketId);

            // Assert
            Assert.IsFalse(shouldApplyAdminCost, 
                "Administration fee should NOT be applied for 500.000001");
            Assert.AreEqual(0m, adminCost, 
                "Administration fee should be $0 for values >= $500");
        }

        [TestMethod]
        public async Task AdminFee_MultipleItems_PrecisionTest()
        {
            // Test scenario with multiple items that sum to exactly 500.00
            // to ensure no floating-point accumulation errors
            
            // Arrange
            var basketId = Guid.NewGuid();
            
            // Add items that sum to exactly 500.00
            var item1 = new BasketLineForCreation
            {
                EventId = Guid.NewGuid(),
                TicketAmount = 1,
                Price = 166.67m
            };
            var item2 = new BasketLineForCreation
            {
                EventId = Guid.NewGuid(),
                TicketAmount = 1,
                Price = 166.67m
            };
            var item3 = new BasketLineForCreation
            {
                EventId = Guid.NewGuid(),
                TicketAmount = 1,
                Price = 166.66m
            };

            // Act
            var line1 = await basketService.AddToBasket(basketId, item1);
            await basketService.AddToBasket(line1.BasketId, item2);
            await basketService.AddToBasket(line1.BasketId, item3);
            
            bool shouldApplyAdminCost = await basketService.ShouldApplyAdministrationCost(line1.BasketId);
            decimal adminCost = await basketService.CalculateAdministrationCost(line1.BasketId);
            decimal totalPrice = await basketService.GetTotalPrice(line1.BasketId);

            // Assert
            // Total should be 166.67 + 166.67 + 166.66 = 500.00
            Assert.IsFalse(shouldApplyAdminCost, 
                "Administration fee should NOT be applied for total of exactly $500.00");
            Assert.AreEqual(0m, adminCost, 
                "Administration fee should be $0 for total of exactly $500.00");
            Assert.AreEqual(500.00m, totalPrice, 
                "Total price should be exactly $500.00 with no admin fee");
        }
    }
}