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
        // Planets map 
        private readonly int[,] map;

        public Mars()
        {
            //   W
            // S   N
            //   E

            map = new int[5, 5]
            {
                { 0, 0, 1 ,0, 0 },
                { 1, 0, 1 ,0, 0 },
                { 0, 0, 1 ,1, 0 },
                { 0, 0, 0 ,0, 0 },
                { 0, 0, 0 ,0, 0 }
            };


        }

        public int[,] Map
        {
            get { return map; }
        }


    }
}
