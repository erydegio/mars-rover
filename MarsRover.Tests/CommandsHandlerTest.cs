using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Tests
{
    public class CommandsHandlerTest
    {

        [Fact]
        public void GivenCommandRShouldTurn()
        {
            //Arrange
            CommandsHandler handler = new CommandsHandler();
            Position p = new Position(0, 0, Directions.N);
            Position expectedPosition = new Position(0, 0, Directions.E);

            char command = 'r';

            //Act
            var result = handler.HandleCommand(command, p);

            //Assert
            Assert.True(result.Turning);
            Assert.False(result.Error);
            Assert.Equal(expectedPosition, result.Position);
        }


        [Fact]
        public void GivenCommandFShoulGoForward()
        {
            //Arrange
            CommandsHandler handler = new CommandsHandler();
            Position p = new Position(0, 0, Directions.N);
            Position expectedPosition = new Position(0, 1, Directions.N);

            char command = 'f';


            //Act
            var result = handler.HandleCommand(command, p);

            //Assert
            Assert.False(result.Turning);
            Assert.False(result.Error);
            Assert.Equal(expectedPosition, result.Position);

        }

        [Fact]
        public void GivenCommandBShoulGoBackward()
        {
            //Arrange
            CommandsHandler handler = new CommandsHandler();
            Position p = new Position(0, 0, Directions.N);
            Position expectedPosition = new Position(0, -1, Directions.N);
           
            char command = 'b';

            //Act
            var result = handler.HandleCommand(command, p);

            //Assert
            Assert.False(result.Turning);
            Assert.False(result.Error);
            Assert.Equal(expectedPosition, result.Position);
        }

        [Fact]
        public void GivenCommandLShouldTurn()
        {
            //Arrange
            CommandsHandler handler = new CommandsHandler();
            Position p = new Position(0, 0, Directions.E);
            Position expectedPosition = new Position(0, 0, Directions.N);

            char command = 'l';

            //Act
            var result = handler.HandleCommand(command,p );

            //Assert
            Assert.True(result.Turning);
            Assert.False(result.Error);
            Assert.Equal(expectedPosition, result.Position);

        }

        [Fact]
        public void GivenCommandJShouldMoveForwardBy2()
        {
            //Arrange
            CommandsHandler handler = new CommandsHandler();
            Position p = new Position(0, 0, Directions.N);
            Position expectedPosition = new Position(0, 2, Directions.N);

            char command = 'j';

            //Act
            var result = handler.HandleCommand(command, p);

            //Assert
            Assert.False(result.Turning);
            Assert.False(result.Error);
            Assert.Equal(expectedPosition, result.Position);
        }

        [Fact]
        public void ShouldSetErrorIfCommandNotImplemented()
        {
            //Arrange
            CommandsHandler handler = new CommandsHandler();
            Position p = new Position(0, 0, Directions.N);
            Position? expectedPosition = null;

            char command = 'w';

            //Act
            var result = handler.HandleCommand(command, p);

            //Assert
            Assert.False(result.Turning);
            Assert.True(result.Error);
            Assert.Equal(expectedPosition, result.Position);

        }

    }


}
    

