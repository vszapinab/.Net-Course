using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L3_L4
{
    public class Rectangle
    {
        private double _width;
        private double _height;

        public double Width
        {
            get { return _width; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Ширина не может быть отрицательной");
                }
                _width = value;
            }
        }

        public double Height
        {
            get { return _height; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Высота не может быть отрицательной");
                }
                _height = value;
            }
        }

        public Rectangle()
        {
        }

        public double GetArea() => Width * Height;
        public double GetPerimeter() => 2 * (Width + Height);
        public bool IsSquare() => Width == Height;
    }
}
