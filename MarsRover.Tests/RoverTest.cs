namespace MarsRover.Tests
{
    public class RoverTest
    {
        [Fact]
        public void RoverClassTest_VerifyStartingPosition()
        {
            //Arrange
            Rover r = new Rover(new Mars());

            int x = 0;
            int y = 0;
            int direction = 'N';

            
            //Act / Assert
            Assert.True(r.X == x);
            Assert.True(r.Y == y);
            Assert.True(r.Directions[r.DirIndex] == direction);
        }

        [Fact]
        public void DetectObstaclesTest_ShouldThrowExceptionIfFoundObstacle()
        {
            // Arrange
            Rover r = new Rover(new Mars());

            int[,] map =
            {
                { 1, 0, 0},
                { 1, 0, 0},
                { 1, 0, 0}
            };

            Instructions instr = new Instructions();
            instr.X = 0;
            instr.Y = 0;
            instr.Direction = 'N';

            //Act / Assert
            Assert.Throws<Exception>(() => r.DetectoObstacles(instr, map));

        }

        [Fact]
        public void DetectObstaclesTest_ShouldReturnFalseIfNotFoudObstacle()
        {
            // Arrange
            Rover r = new Rover(new Mars());

            int[,] map =
            {
                { 1, 0, 0},
                { 1, 0, 0},
                { 1, 0, 0}
            };

            Instructions instr = new Instructions();
            instr.X = 0;
            instr.Y = 1;
            instr.Direction = 'N';

            //Act / Assert
            Assert.False(r.DetectoObstacles(instr, map));
        }

        [Fact]

        public void MoveTest_ShouldUpdateRoverPositionGivenInstructions()
        {
            // Arrange
            Instructions instr = new Instructions();
            instr.X = 1;
            instr.Y = 1;
            instr.Direction = 4;

            Rover r = new Rover(new Mars());

            //Act
            r.Move(instr);

            //Assert
            Assert.True(r.X == 1);
            Assert.True(r.Y == 1);
            Assert.True(r.DirIndex == 4);
        }







    }
}