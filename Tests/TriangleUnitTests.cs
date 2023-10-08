using Shapes;
using Shapes.ExtensionMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tests.Data;

namespace Tests
{
    public class TriangleUnitTests
    {
        [Fact]
        public void ShouldCalculateSquareWhenTriangleIsAbleToConstruct()
        {
            Shape shape = new Triangle(5, 6, 6.7);
            var expected = 14.4491;
            Assert.Equal(expected, shape.CalculateSquare());
        }

        [Theory]
        [ClassData(typeof(TriangleTestData))]
        public void ShouldThrowArgumentExceptionWhenTriangleNotValid(double a ,double b, double c)
        {
            Assert.Throws<ArgumentException>(() => new Triangle(a ,b ,c));
        }

        [Fact]
        public void ShouldReturnTrueWhenTriangleRight()
        {
            Triangle right = new Triangle(3, 4, 5);
            Assert.True(right.IsRight());
        }
        [Fact]
        public void ShouldReturnFalseWhenTriableIsNotRight()
        {
            Triangle notRight = new Triangle(7, 8, 14);
            Assert.False(notRight.IsRight()); 
            
        } 
        
    }
}
