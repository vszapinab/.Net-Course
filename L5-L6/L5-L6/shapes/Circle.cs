using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L5_L6.shapes
{
    internal class Circle : Shape
    {
        public int Radius { get; set; }
        public override double GetArea() 
        { 
            return Math.PI * Math.Pow(this.Radius, 2); 
        }
    }
}
