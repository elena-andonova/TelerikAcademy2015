using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.TriangleSurface
{
    class TriangleSurface
    {
        
    //Write methods that calculate the surface of a triangle by given:
    //    Side and an altitude to it;
    //    Three sides;
    //    Two sides and an angle between them;
    //Use System.Math.

        static void Main()
        {
            Console.WriteLine("Choose by which method you want to be calculated the surface of the triangle:");
            Console.WriteLine(" 1 --> Side and an altitude to it \n 2 --> Three sides \n 3 --> Two sides and an angle between them");
            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    {
                        Console.Write("Side = ");
                        double side = double.Parse(Console.ReadLine());
                        Console.Write("Altitude = ");
                        double altitude = double.Parse(Console.ReadLine());
                        double surface = SurfaceBySideAndAltitude(side, altitude);
                        Console.WriteLine("Surface = {0}", surface);
                    }
                    break;
                case 2:
                    {
                        Console.Write("Side a = ");
                        double a = double.Parse(Console.ReadLine());
                        Console.Write("Side b = ");
                        double b = double.Parse(Console.ReadLine());
                        Console.Write("Side c = ");
                        double c = double.Parse(Console.ReadLine());
                        double surface = SurfaceByThreeSides(a, b, c);
                        Console.WriteLine("Surface = {0}", surface);
                    }
                    break;
                case 3:
                    {
                        Console.Write("Side a = ");
                        double a = double.Parse(Console.ReadLine());
                        Console.Write("Side b = ");
                        double b = double.Parse(Console.ReadLine());
                        Console.Write("Angle alfa = ");
                        double alfa = double.Parse(Console.ReadLine());
                        double surface = SurfaceByTwoSidesAndAngle(a, b, alfa);
                        Console.WriteLine("Surface = {0}", surface);
                    }
                    break;
                default: Console.WriteLine("Invalid option!"); break;
            }
        }

        static double SurfaceBySideAndAltitude(double side, double altitude)
        {
            double surface = 0.5 * side * altitude;
            return surface;
        }

        static double SurfaceByThreeSides(double side1, double side2, double side3)
        {
            double s = 0.5 * (side1 + side2 + side3);   
            double surface = Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
            return surface;
        }

        static double SurfaceByTwoSidesAndAngle(double side1, double side2, double degrees)
        {
            double sin = Math.Sin(degrees * ((Math.PI) / 180));
            double surface = 0.5 * side1 * side2 * sin;
            return surface;
        }
    }
}
