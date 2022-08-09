using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{

    public class Instructions
    {


        private Position position;
        private bool turning = false;
        private bool error = false;


        public bool Turning
        {
            get { return turning; }
            set { turning = value; }
        }

        public Position Position
        {
            get { return position; }
            set
            {
                position = value;
            }
        }

        public bool Error
        {
            get { return error; }
            set { error = value; }
        }

    }
}

  