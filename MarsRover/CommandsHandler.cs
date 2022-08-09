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
        /// <param name="rover">A rover object, the new instructions are based on its state</param>
        /// <returns>Return an Instructions object</returns>
        public Instructions HandleCommand(char command, Position position)
        {

            Instructions instruction = new();
            
            if (command == 'r')
            {
                RCommandHandler handler = new();
                instruction.Position = handler.HandleCommand(position);
                instruction.Turning = true;
            }
            else if (command == 'j')
            {
                JCommandHandler handler = new();
                instruction.Position = handler.HandleCommand(position);
            }
            else if (command == 'l')
            {
                LCommandHandler handler = new();
                instruction.Position = handler.HandleCommand(position);
                instruction.Turning = true;

            }
            else if (command == 'f')
            {
                FCommandHandler handler = new();
                instruction.Position = handler.HandleCommand(position);

            }
            else if (command == 'b')
            {
                BCommandHandler handler = new();
                instruction.Position = handler.HandleCommand(position);

            }
            else
            {
                // If is given a wrong command
                instruction.Error = true;
                return instruction;
            }
            
            return instruction;
        }
    }
}
