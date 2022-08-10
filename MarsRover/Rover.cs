using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    public class Rover
    {

        private Position position;
        private CommandsHandler c = new CommandsHandler();
        private Mars planet = new Mars();


        public Rover(Mars planet)
        {

            this.planet = planet;
            position = new Position(0, 0, 0);
            Console.WriteLine($"....STARTING POSITION {position.Direction}({position.X},{position.Y})....\n");
        }

        public Position Position
        {
            get { return position; }
            set { position = value; }
        }


        public Mars Planet
        {
            get { return planet; }
        }


        /// <summary>
        /// Detect an obstacle (represented on the map grid by int 1)
        /// </summary>
        /// <param name="ins">Instructions given to the rover for its next move</param>
        /// <param name="map">The grid representing the planet field</param>
        /// <returns>Throw an error if an obstacle is deteced</returns>
        public bool DetectoObstacles(Position p)
        {
         
            if (planet.Map[p.X, p.Y] != 0)
            {
                return true;
            }
            return false;
        }

        // Receive a character array of commands and turn them into movements
        public void GetCommands(char[] commands)
        {

            foreach (char command in commands)
            {

                // Read the command and create an Instruction object
                Instructions instructions = c.HandleCommand(command, this.position);              

                // If is given a wrong command print an error and read the next command
                if (instructions.Error)
                {
                    Console.WriteLine("Error..Command not implemented..");
                    continue;
                }

                // Give instructions to the rover and update its cordinates ("moves")
                if (!Move(instructions))
                {
                    // If is detected an obstacle break the loop and show an abort message
                    Console.WriteLine("OBSTACLE DETECTED...ABORT\n");
                    break;
                };
                Console.WriteLine($"Rover moved, new position: {position.Direction}({Position.X},{position.Y})....\n");
            }
        }

        // Set rover new position wrapping the coordinates        
        public bool Move(Instructions i)
        {
            //wrap the position in according to the planet grid / coordinates
            i.Position = planet.Wrap(i.Position);

            // If the rover moves forward/backward and detect an obstacle
            if ((!i.Turning) && DetectoObstacles(i.Position))
            {
                return false;
            }

            this.position = i.Position;
            return true;
        }

        
    }
}
