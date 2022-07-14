using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{

    public class Instructions
    {
        private int x;
        private int y;
        private int direction;
        private bool turning = false;
        private bool error = false;

        public bool Turning
        {
            get { return turning; }
            set { turning = value; }
        }
        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        public int Direction
        {
            get { return direction; }
            set { direction = value; }
        }

        public bool Error
        {
            get { return error; }
            set { error = value; }
        }


    }
}
