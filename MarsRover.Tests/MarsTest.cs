using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Tests
{
    public class MarsTest
    {

        [Theory]
        [InlineData(5, 0)]
        [InlineData(-1, 4)]
        [InlineData(1, 1)]
        public void WrapMapTest_ShouldWrapValueIntoMapBoundary(int coordinate, int expected)
        {
            //Arrange
            Mars planet = new Mars();

            // Act
            var result = planet.WrapMap(coordinate);

            //Assert
            Assert.Equal(expected, result);

        }

        [Theory]
        [InlineData((Directions)(4), Directions.N)]
        [InlineData((Directions)(-1), Directions.W)]
        [InlineData(Directions.N, Directions.N)]

        public void WrapDirectionTest_ShouldWrapValueIntoDirectionsLimit(Directions position, Directions expected)
        {
            //Arrange
            Mars planet = new Mars();

            // Act
            var result = planet.WrapDirection(position);

            //Assert
            Assert.Equal(expected, result);

        }

        [Fact]
        public void WrapTest_ShouldReturnWrappedPosition()
        {
            //Arrange
            Mars planet = new Mars();
            Position p = new Position(-1, 0, Directions.N);
            Position expected = new Position(4, 0, Directions.N);


            //Act
            var result = planet.Wrap(p);

            //Assert
            Assert.Equal(expected, result);
        }




    }
}
