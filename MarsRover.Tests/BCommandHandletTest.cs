using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Tests
{
    public class BCommandHandlerTest
    {
        [Fact]
        public void GivenPositionFacingNShouldDecrementY()
        {
            //Arrange
            BCommandHandler handler = new BCommandHandler();
            Position p = new Position(0, 0, Directions.N);
            Position expected = new Position(0, -1, Directions.N);

            //Act
            var result = handler.HandleCommand(p);

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void GivenPositionFacingEShouldDecrementX()
        {
            //Arrange
            BCommandHandler handler = new BCommandHandler();
            Position p = new Position(0, 0, Directions.E);
            Position expected = new Position(-1, 0, Directions.E);


            //Act
            var result = handler.HandleCommand(p);

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void GivenPositionFacingSShouldIncrementY()
        {
            //Arrange
            BCommandHandler handler = new BCommandHandler();
            Position p = new Position(0, 0, Directions.S);
            Position expected = new Position(0, 1, Directions.S);

            //Act
            var result = handler.HandleCommand(p);

            //Assert
            Assert.Equal(expected, result);

        }

        [Fact]
        public void GivenPositionFacingWShouldIncrementX()
        {
            //Arrange
            BCommandHandler handler = new BCommandHandler();
            Position p = new Position(0, 0, Directions.W);
            Position expected = new Position(1, 0, Directions.W);


            //Act
            var result = handler.HandleCommand(p);

            //Assert
            Assert.Equal(expected, result);

        }



    }
}