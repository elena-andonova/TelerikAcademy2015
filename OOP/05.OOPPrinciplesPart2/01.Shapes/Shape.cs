using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Shapes
{
    //Define abstract class Shape with only one abstract method CalculateSurface() and fields width and height.
    public abstract class Shape
    {
        private double width;
        private double height;

        public Shape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width
        {
            get { return this.width; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Width must be > 0!");
                }
                this.width = value;
            }
        }
        public double Height
        {
            get { return this.height; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Height must be > 0!");
                }
                this.height = value;
            }
        }   
        public virtual double CalculateSurface()
        {
            double result = 0;
            result = this.Width * this.Height;
            return result;
        }
    }
}


