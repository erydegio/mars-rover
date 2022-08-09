using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Tests
{
    public class LCommandHandlerTest
    {

        [Fact]
        public void GivenPositionDirectionValueShoulDecrement()
        {
            //Arrange
            Position p = new Position(0, 0, Directions.N);
            LCommandHandler handler = new LCommandHandler();
            Position expected = new Position(0, 0, (Directions)(-1));

            //Act
            Position result = handler.HandleCommand(p);

            //Assert
            Assert.Equal(expected, result);

        }
    }
}
