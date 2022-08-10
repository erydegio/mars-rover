using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    /// <summary>
    /// The map of Mars.
    /// </summary>
    public class Mars
    {
        private readonly int[,] map;

        // Boundaries
        int maxLimit;
        int minLimit = 0;


    public Mars()
    {
            //   W
            // S   N
            //   E

            map = new int[5, 5]
            {
                { 0, 0, 0 ,0, 0 },
                { 1, 0, 1 ,0, 0 },
                { 0, 0, 1 ,1, 0 },
                { 0, 0, 0 ,0, 0 },
                { 0, 0, 0 ,0, 0 }
            };
         
            maxLimit = map.GetLength(0) - 1;
        }

        public int[,] Map
        {
            get { return map; }
        }


        // Wrap a value between 0 and its maxindex (boundary)
        // value in position, max in map
        public int WrapMap(int value)
        {

            if (value < minLimit)
            {
                return map.GetLength(0) -1;
            }
            else if (value > maxLimit)
            {
                return minLimit;
            }
            return value;

        }
   
        public Directions WrapDirection(Directions dir)
        {
            if( (int)dir < 0)
            {
                return Directions.W; 
            }
            else if ((int)dir > (int)Directions.W){
                return Directions.N;
            }

            return dir;
        }

        public Position Wrap(Position p)
        {
            return new Position(
                    WrapMap(p.X),
                    WrapMap(p.Y),
                    WrapDirection(p.Direction));
        }

    }
}
