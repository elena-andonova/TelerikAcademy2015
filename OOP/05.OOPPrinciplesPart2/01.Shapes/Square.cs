using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Shapes
{
    //Define class Square and suitable constructor so that at initialization height must be kept equal to width and implement the CalculateSurface() method.
    class Square : Rectangle
    {
        public Square(double side)
            : base(side, side)
        {

        }
    }
}
