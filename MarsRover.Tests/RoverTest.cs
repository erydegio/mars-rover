namespace MarsRover.Tests
{
    public class RoverTest
    {
        [Fact]
        public void CheckStartingPosition()
        {
            //Arrange
            Rover r = new Rover(new Mars());
            Position expected = new Position(0, 0, Directions.N);
            
            //Act / Assert
            Assert.Equal(expected, r.Position);

        }

        [Fact]
        public void DetectObstaclesTest_ShouldReturnTrueIfFoundObstacle()
        {
            // Arrange
            Rover r = new Rover(new Mars());
            Position p = new Position(1, 2, Directions.N);

            //Act / Assert
            Assert.True(r.DetectoObstacles(p));
        }

        [Fact]
        public void DetectObstaclesTest_ShouldReturnFaklseIfNotFoundObstacle()
        {
            // Arrange
            Rover r = new Rover(new Mars());
            Position p = new Position(0, 2, Directions.N);

            //Act / Assert
            Assert.False(r.DetectoObstacles(p));
        }


        [Fact]
        public void MoveTest_GivingInstructionToObstacleShoulReturnFalse()
        {
            // Arrange
            Instructions instr = new Instructions();
            instr.Position = new Position(1, 2, Directions.N);
            Rover r = new Rover(new Mars());

            //Act
            var result = r.Move(instr);

            //Assert
            Assert.False(result);
            
        }

        [Fact]
        public void MoveTest_GivingCorrectInstructionShouldReturnTrue()
        {
            // Arrange
            Instructions instr = new Instructions();
            instr.Position = new Position(1, 1, Directions.N);
            Rover r = new Rover(new Mars());

            //Act
            var result = r.Move(instr);

            //Assert
            Assert.True(result);

        }

        [Fact]
        public void MoveTest_GivingCorrectInstructionShouldUpdateRoverPosition()
        {
            // Arrange
            Instructions instr = new Instructions();
            instr.Position = new Position(1, 1, Directions.N);
            Rover r = new Rover(new Mars());
            Position expected = new Position(1, 1, Directions.N);

            //Act
            r.Move(instr);

            //Act/ Assert
            Assert.Equal( expected, r.Position);
        }

    }
}