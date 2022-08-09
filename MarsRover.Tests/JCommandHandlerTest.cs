using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Tests
{
    public class JCommandHandlerTest
    {
        [Fact]
        public void GivenPositionFacingNShouldIncrementYBy2()
        {
            //Arrange
            JCommandHandler handler = new JCommandHandler();
            Position p = new Position(0, 0, Directions.N);
            Position expected = new Position(0, 2, Directions.N);

            //Act
            var result = handler.HandleCommand(p);

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void GivenPositionFacingEShouldIncrementXBy2()
        {
            //Arrange
            JCommandHandler handler = new JCommandHandler();
            Position p = new Position(0, 0, Directions.E);
            Position expected = new Position(2, 0, Directions.E);

            //Act
            var result = handler.HandleCommand(p);

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void GivenPositionFacingSShouldDecrementYBy2()
        {
            //Arrange
            JCommandHandler handler = new JCommandHandler();
            Position p = new Position(0, 0, Directions.S);
            Position expected = new Position(0, -2, Directions.S);

            //Act
            var result = handler.HandleCommand(p);

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void GivenPositionFacingWShouldDecrementXBy2()
        {
            //Arrange
            JCommandHandler handler = new JCommandHandler();
            Position p = new Position(0, 0, Directions.W);
            Position expected = new Position(-2, 0, Directions.W);


            //Act
            var result = handler.HandleCommand(p);

            //Assert
            Assert.Equal(expected, result);
        }
    }
}
    

