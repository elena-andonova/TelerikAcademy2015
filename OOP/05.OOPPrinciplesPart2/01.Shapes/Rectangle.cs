using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Shapes
{
    //Define two new classes Triangle and Rectangle that implement the virtual method and return the surface of the figure (height * width for rectangle and height * width/2 for triangle).
    public class Rectangle : Shape
    {
        public Rectangle(double height, double width)
            : base(width, height)
        {

        }

        public override double CalculateSurface()
        {
            return base.CalculateSurface();
        }
    }
}
