﻿using FunWithQuadTrees.Logic;
using Xunit;

namespace FunWithQuadTrees.Testing
{
    public class RectangleHelperTests
    {
        [Theory]
        [InlineData(100, 100, 100, 100, 0, 0)]
        [InlineData(100, 100, 0, 0, 100, 100)]
        public void GetNorthEastShallReturnAsExpected(
            decimal xExpected, decimal yExpected, 
            decimal x1, decimal y1, 
            decimal x2, decimal y2)
        {
            // Arrange
            var rect = new Rectangle(x1: x1, y1: y1, x2: x2, y2: y2);

            // Act
            var corner = rect.GetNorthEast();

            // Assert
            Assert.Equal(xExpected, corner.X);
            Assert.Equal(yExpected, corner.Y);
        }

        [Theory]
        [InlineData(100, 0, 100, 100, 0, 0)]
        [InlineData(100, 0, 0, 0, 100, 100)]
        public void GetSouthEastShallReturnAsExpected(
            decimal xExpected, decimal yExpected,
            decimal x1, decimal y1,
            decimal x2, decimal y2)
        {
            // Arrange
            var rect = new Rectangle(x1: x1, y1: y1, x2: x2, y2: y2);

            // Act
            var corner = rect.GetSouthEast();

            // Assert
            Assert.Equal(xExpected, corner.X);
            Assert.Equal(yExpected, corner.Y);
        }

        [Theory]
        [InlineData(true, 100, 100, 100, 100, 0, 0)]
        [InlineData(true, 100, 100, 0, 0, 100, 100)]
        [InlineData(true, 50, 50, 0, 0, 100, 100)]
        [InlineData(false, -100, 100, 0, 0, 100, 100)]
        [InlineData(false, 100, -100, 0, 0, 100, 100)]
        [InlineData(false, -0.1f, -0.1f, 0.1f, 0.1f, 100, 100)]
        [InlineData(true, 1.2566288E-7, 1.2566288E-7, -0.1f, -0.1f, 0.1f, 0.1f)]
        public void ContainsPointShallReturnAsExpected(
            bool expectedResult,
            decimal xTest, decimal yTest,
            decimal x1, decimal y1,
            decimal x2, decimal y2)
        {
            // Arrange
            var rect = new Rectangle(x1: x1, y1: y1, x2: x2, y2: y2);

            // Act
            var result = rect.ContainsPoint(new DataPoint(xTest, yTest));

            // Assert
            Assert.Equal(expectedResult, result);
        }
    }
}