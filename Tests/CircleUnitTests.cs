using Shapes;
using System.Reflection.Metadata.Ecma335;

namespace Tests
{
    public class CircleUnitTests
    {
        [Fact]
        public void CircleShouldReturnSquareWhenArgumentsCorrect()
        {
            //Arrange
            Circle circle = new Circle(8);
            double expected = 201.0619;

            //Act
            var square = circle.CalculateSquare();

            //Assert
            Assert.Equal(expected, square);
            
        }

        [Fact] 
        public void CircleShouldThrowArgumentExceptionWhenNegativeValueSet()
        {
            Assert.Throws(typeof(ArgumentException), () => new Circle(-1));
        }
    }
}