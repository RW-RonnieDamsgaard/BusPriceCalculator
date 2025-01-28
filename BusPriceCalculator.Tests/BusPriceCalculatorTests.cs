using Xunit;
using BusPriceCalculator;

namespace BusPriceCalculator.Tests
{
    public class BusPriceCalculatorTests
    {
        [Fact]
        public void CalculatePrice_DistanceBelow100Km_ReturnsCorrectPrice()
        {
            // Arrange
            int distance = 50;
            int expectedPrice = 2500 + (50 * 10); // Initial fee + 50 km * 10 kr/km

            // Act
            int actualPrice = BusPriceCalculator.CalculatePrice(distance);

            // Assert
            Assert.Equal(expectedPrice, actualPrice);
        }

        [Fact]
        public void CalculatePrice_DistanceBetween100And500Km_ReturnsCorrectPrice()
        {
            // Arrange
            int distance = 300;
            int expectedPrice = 2500 + (100 * 10) + (200 * 8); // Initial fee + 100 km * 10 kr/km + 200 km * 8 kr/km

            // Act
            int actualPrice = BusPriceCalculator.CalculatePrice(distance);

            // Assert
            Assert.Equal(expectedPrice, actualPrice);
        }

        [Fact]
        public void CalculatePrice_DistanceAbove500Km_ReturnsCorrectPrice()
        {
            // Arrange
            int distance = 600;
            int expectedPrice = 2500 + (100 * 10) + (400 * 8) + (100 * 6); // Initial fee + 100 km * 10 kr/km + 400 km * 8 kr/km + 100 km * 6 kr/km

            // Act
            int actualPrice = BusPriceCalculator.CalculatePrice(distance);

            // Assert
            Assert.Equal(expectedPrice, actualPrice);
        }

        [Fact]
        public void CalculatePrice_DistanceExactly100Km_ReturnsCorrectPrice()
        {
            // Arrange
            int distance = 100;
            int expectedPrice = 2500 + (100 * 10); // Initial fee + 100 km * 10 kr/km

            // Act
            int actualPrice = BusPriceCalculator.CalculatePrice(distance);

            // Assert
            Assert.Equal(expectedPrice, actualPrice);
        }

        [Fact]
        public void CalculatePrice_DistanceExactly500Km_ReturnsCorrectPrice()
        {
            // Arrange
            int distance = 500;
            int expectedPrice = 2500 + (100 * 10) + (400 * 8); // Initial fee + 100 km * 10 kr/km + 400 km * 8 kr/km

            // Act
            int actualPrice = BusPriceCalculator.CalculatePrice(distance);

            // Assert
            Assert.Equal(expectedPrice, actualPrice);
        }
    }
}