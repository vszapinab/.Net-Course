using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L5_L6.shapes
{
    internal class Rectangle : Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public override double GetArea() 
        { 
            return Width * Height; 
        }
    }
}
