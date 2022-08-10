using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{

    /// <summary>
    /// Read the current position of the rover and return new coordinates
    /// </summary>
    /// <param name="p">The actual position of the rover before receiving a command</param>
    /// <returns> Rover next position</returns>
    public interface ICommandHandler
    {
        Position HandleCommand(Position p);
    }

    #region HANDLERS
    // 'j' handler
    public class JCommandHandler : ICommandHandler
    {
        public Position HandleCommand(Position p)
        {
            if (p.Direction == Directions.N)
            {
                
                return p with { Y = p.Y + 2 };

            } 
            else if (p.Direction == Directions.E)
            {
                return p with { X = p.X + 2 };
            }
            else if (p.Direction == Directions.S)
            {
                return p with { Y = p.Y - 2 };

            }
            else
            {
                return p with { X = p.X - 2 };

            }
        }
    }

    // 'r' handler
    public class RCommandHandler : ICommandHandler
    {
        public Position HandleCommand(Position p)
        {
            return p with { Direction = p.Direction + 1 };
        }
    }

    // 'l' handler
    public class LCommandHandler : ICommandHandler
    {
        public Position HandleCommand(Position p)
        {
            return p with { Direction = p.Direction - 1 };
        }
    }

    // 'f' handler
    public class FCommandHandler : ICommandHandler
    {
        public Position HandleCommand(Position p)
        {
            
            if (p.Direction == Directions.N)
            {
                return p with { Y = p.Y + 1 };

            }
            else if (p.Direction == Directions.E)
            {
                return p with { X = p.X + 1 };

            }
            else if (p.Direction == Directions.S)
            {
                return p with { Y = p.Y - 1 };

            }
            else
            {
                return p with { X = p.X - 1 };
            }

        }
    }

    // 'b' handler
    public class BCommandHandler : ICommandHandler
    {
        public Position HandleCommand(Position p)
        {
            if (p.Direction == Directions.N)
            {
                return p with { Y = p.Y - 1 };

            }
            else if (p.Direction == Directions.E)
            {
                return p with { X = p.X - 1 };

            }
            else if (p.Direction == Directions.S)
            {
                return p with { Y = p.Y + 1 };

            }
            else
            {
                return p with { X = p.X + 1 };
            }
        }
    }
    #endregion


    public record Position(int X, int Y, Directions Direction);


    
    public enum Directions
    {
        N = 0,
        E,
        S,
        W
    }


}
