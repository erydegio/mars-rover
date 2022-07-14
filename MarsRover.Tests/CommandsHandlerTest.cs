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
        public void CommandsHandlerTest_GivenCommandlShouldTurnLeft()
        {
            //Arrange
            CommandsHandler handler = new CommandsHandler();
            Rover r = new Rover(new Mars());

            int[,] map = r.PlanetMap.Map; 
            char command = 'l';

            //Act
            var result = handler.HandleCommand(command,map, r);

            //Assert
            Assert.Equal(3, result.Direction);
            Assert.True(result.Turning);
        }

        [Fact]
        public void CommandsHandlerTest_GivenCommandrShouldTurnRight()
        {
            //Arrange
            CommandsHandler handler = new CommandsHandler();
            Rover r = new Rover(new Mars());

            int[,] map = r.PlanetMap.Map;
            char command = 'r';

            //Act
            var result = handler.HandleCommand(command, map, r);

            //Assert
            Assert.Equal(1, result.Direction);
            Assert.True(result.Turning);
        }


        [Fact]
        public void CommandsHandlerTest_GivenCommandfRoverShoulGoForward()
        {
            //Arrange
            CommandsHandler handler = new CommandsHandler();
            Rover r = new Rover(new Mars());

            int[,] map = r.PlanetMap.Map;
            char command = 'f';
            int expectedMapPositionY = 1;


            //Act
            var result = handler.HandleCommand(command, map, r);

            //Assert
            Assert.Equal(expectedMapPositionY, result.Y);

        }

        [Fact]
        public void CommandsHandlerTest_GivenCommandbRoverShoulGoBackward()
        {
            //Arrange
            CommandsHandler handler = new CommandsHandler();
            Rover r = new Rover(new Mars());

            int[,] map = r.PlanetMap.Map;
            char command = 'b';
            int expectedMapPositionY = 4;

            //Act
            var result = handler.HandleCommand(command, map, r);

            //Assert
            Assert.Equal(expectedMapPositionY, result.Y);

        }

        [Fact]
        public void HandleCommandTest_ShouldMoveOnXAxisGivenCommandbAndRoverFacingWest()
        {
            //Arrange
            CommandsHandler handler = new CommandsHandler();
            Rover r = new Rover(new Mars());
            r.DirIndex = 1;

            int[,] map = r.PlanetMap.Map;
            char command = 'b';
            int expectedMapPositionX = 4;

            //Act
            var result = handler.HandleCommand(command, map, r);

            //Assert
            Assert.Equal(expectedMapPositionX, result.X);

        }

        [Fact]
        public void HandleCommandTest_ShouldMoveOnXAxisGivenCommandfAndRoverFacingWest()
        {
            //Arrange
            CommandsHandler handler = new CommandsHandler();
            Rover r = new Rover(new Mars());
            r.DirIndex = 1;

            int[,] map = r.PlanetMap.Map;


            char command = 'f';
            int expectedMapPositionX = 1;

            //Act
            var result = handler.HandleCommand(command, map, r);

            //Assert
            Assert.Equal(expectedMapPositionX, result.X);

        }

        [Fact]
        public void HandleCommandTest_ShouldSetErrorIfCommandNotImplemented()
        {
            //Arrange
            CommandsHandler handler = new CommandsHandler();
            Rover r = new Rover(new Mars());
            r.DirIndex = 1;

            int[,] map = r.PlanetMap.Map;


            char command = 'w';
            bool expectedErrorFlag = true;

            //Act
            var result = handler.HandleCommand(command, map, r);

            //Assert
            Assert.Equal(expectedErrorFlag, result.Error);

        }

        
        [Theory]
        [InlineData(3, 2, 0)]
        [InlineData(-1, 2, 2)]
        public void WrapTest_ShouldWrapNumberReachedItsMaxOrMinValue(int position, int maxvalue, int expected)
        {
            //Arrange
            CommandsHandler handler = new CommandsHandler();

            // Act
            var result = handler.Wrap(position, maxvalue);

            //Assert
            Assert.Equal(expected, result);

        }



    }
}
