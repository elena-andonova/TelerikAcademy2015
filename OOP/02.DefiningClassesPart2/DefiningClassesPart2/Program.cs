using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart2
{
     class Program
    {
        static void Main()
        {
            //Console.WriteLine(Point3D.O.ToString());

            //Point3D point1 = new Point3D(1, 2, 3);
            //Point3D point2 = new Point3D(3, 4, 6);
            
            //Console.WriteLine(StaticClass.CalculateDistance(point1, point2));
            GenericList<int> list = new GenericList<int> {1,2,3, 7, 3};
            Console.WriteLine(list.FindElementByValue(3));
            SampleClass.Sample();
        }
    }
}
