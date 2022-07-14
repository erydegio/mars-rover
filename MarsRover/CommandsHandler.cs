using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{

    /// <summary>
    /// Translate remote commands into instructions understood by the rover
    /// </summary>
    public class CommandsHandler
    {

        /// <summary>
        /// Translate a command into an instruction 
        /// </summary>
        /// <param name="command">A single command</param>
        /// <param name="map">The grid representing the planet field</param>
        /// <param name="rover">A rover object, the new instructions are based on its state</param>
        /// <returns>Return an Instructions object</returns>
        public Instructions HandleCommand(char command, int[,] map, Rover rover)
        {
            // Rover starting state
            int newX = rover.X;
            int newY = rover.Y;
            int newDirIndex = rover.DirIndex;

            // Boundaries for wrap
            int mapMaxWidth = map.GetLength(1) -1;
            int mapMaxHeight = map.GetLength(0) -1;
            int maxDirectionIndex = rover.Directions.Length - 1;

            // The actual direction the rover is facing
            char direction = rover.Directions[rover.DirIndex];

            Instructions instruction = new Instructions();

            if (command == 'r')
            {
                newDirIndex++;
                instruction.Turning = true;
            }
            else if (command == 'l')
            {
               newDirIndex--;
               instruction.Turning = true;

            }
            else if (direction == 'N' && command == 'f' ||
                     direction == 'S' && command == 'b')
            {
                newY++;

            }
            else if (direction == 'S' && command == 'f' ||
                     direction == 'N' && command == 'b')
            {
                newY--;

            }
            else if (direction == 'E' && command == 'f' ||
                     direction == 'W' && command == 'b')
            {
                newX++;

            }
            else if (direction == 'W' && command == 'f' ||
                     direction == 'E' && command == 'b')
            {
                newX--;
            }
            else
            {
                // If is given a wrong command
                instruction.Error = true;
                return instruction;
            }

            // Assign new codrinates to the Instructions object
            instruction.X = Wrap(newX, mapMaxWidth);
            instruction.Y = Wrap(newY, mapMaxHeight);
            instruction.Direction = Wrap(newDirIndex, maxDirectionIndex);

            return instruction;
        }

        // Wrap a value between 0 and its maxindex (boundary)
        public int Wrap(int value, int max)
        {

            if (value < 0)
            {
                return max;
            }
            else if (value > max)
            {
                return 0;
            }
            return value;
        }
    }
}
