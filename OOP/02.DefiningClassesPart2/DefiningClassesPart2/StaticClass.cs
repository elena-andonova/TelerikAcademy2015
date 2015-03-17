using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart2
{
    //Problem 3. Static class
    //Write a static class with a static method to calculate the distance between two points in the 3D space.

    static class StaticClass
    {
        public static double CalculateDistance(Point3D p, Point3D q)
        {
            //Euclidian distance
            return Math.Sqrt(Math.Pow((p.X - q.X), 2) + Math.Pow((p.Y - q.Y), 2) + Math.Pow((p.Z - q.Z), 2));
        }
    }
}
