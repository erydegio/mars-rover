using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Tests
{
    public class RCommandHandlerTest
    {

        [Fact]
        public void GivenPositionDirectionValueShouldIncrement()
        {
            //Arrange
            Position p = new Position(0,0,Directions.N);
            RCommandHandler handler = new RCommandHandler();
            Position expected = new Position(0, 0, Directions.E);


            //Act
            Position result = handler.HandleCommand(p);

            //Assert
            Assert.Equal(expected, result);
            
        }


    }
}
