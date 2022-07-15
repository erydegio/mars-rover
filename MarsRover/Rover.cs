using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    public class Rover
    {
        // Rover cordinates
        private int x;
        private int y;
        private int dirIndex;
        private readonly char[] directions;
        private CommandsHandler c = new CommandsHandler();
        private Mars planetMap = new Mars();


        public Rover(Mars planetMap)
        {
            x = 0;
            y = 0;
            dirIndex = 0;
            directions = new char[4] { 'N', 'E', 'S', 'W' };
            this.planetMap = planetMap;

            Console.WriteLine($"....STARTING POSITION {directions[dirIndex]}({x},{y})....\n");
        }

        public CommandsHandler C {
            get { return c; }
            }

        public Mars PlanetMap
        {
            get { return planetMap; }
        }

        public int DirIndex
        {
            get { return dirIndex;}
            set { dirIndex = value; }
        }

        public char[] Directions
        {
            get { return directions;}
        }

        public int Y
        {
            get { return y;}
            set { y = value;}
        }

        public int X
        {
            get { return x;}
            set { x = value;}
        }


        /// <summary>
        /// Detect an obstacle (represented on the map grid by int 1)
        /// </summary>
        /// <param name="ins">Instructions given to the rover for its next move</param>
        /// <param name="map">The grid representing the planet field</param>
        /// <returns>Throw an error if an obstacle is deteced</returns>
        public bool DetectoObstacles(Instructions ins, int[,] map)
        {
         
            if (map[ins.X, ins.Y] != 0)
            {
                throw new Exception();
                
            }
            return false;
        }

        // Receive a character array of commands and turn them into movements
        public void GetCommands(char[] commands)
        {

            foreach (char command in commands)
            {
                int[,] map = PlanetMap.Map;

                // Read the command and create an Instruction object
                Instructions instructions = c.HandleCommand(command, map, this);

                // If is given a wrong command print an error and read the next command
                if (instructions.Error)
                {
                    Console.WriteLine("Error..Command not implemented..");
                    continue;
                }

                // If the rover moves forward/backward detect obstacles
                if (!instructions.Turning)
                {
                    try
                    {
                        DetectoObstacles(instructions, map);
                    }
                    catch (Exception)
                    {
                        // If is detected an obstacle break the loop and show an abort message
                        Console.WriteLine("OBSTACLE DETECTED...ABORT");
                        break;
                    }
                }

                // Give instructions to the rover and update its cordinates ("moves")
                Move(instructions);
                Console.WriteLine($"Rover moved, new position: {Directions[DirIndex]}({X},{Y})....");

            }
            Console.WriteLine("\n");
        }

        //Update the state of the rover with the new cordinates
        public void Move(Instructions ins)
        {
            x = ins.X;
            y = ins.Y;
            dirIndex = ins.Direction;
        }

        
    }
}
