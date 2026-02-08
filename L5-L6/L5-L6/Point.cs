using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L5_L6
{
    struct Point
    {
        public int x;
        public int y;

        public int DistanceFromZero () 
        {
            return x * x + y * y; 
        }

    }
}
