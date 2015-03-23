using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DefiningClassesPart2
{
//Create a static class PathStorage with static methods to save and load paths from a text file.
//Use a file format of your choice.
    class PathStorage
    {
        public static void Save(Path path)
        {
            string filepath = string.Format(@"..\..\test.txt");
            StreamWriter writer = new StreamWriter(filepath);
            using (writer)
            {
                foreach (var point in path.PathList)
                {
                    string strTosave = point.X.ToString() + " " + point.Y.ToString() + " " + point.Z.ToString();
                    writer.WriteLine(strTosave);
                }
            }
        }
        public static Path Load()
        {
            Path path = new Path();
            string filepath = string.Format(@"..\..\test.txt");
            StreamReader reader = new StreamReader(filepath);
            string[] pointsArr;
            using (reader)
            {
                string wholeFile = reader.ReadToEnd();
                pointsArr = wholeFile.Split('\n');
            }
            foreach (var line in pointsArr)
            {
                if (line != "")
                {
                    string[] thePointCoords = line.Split(' ');
                    double x = double.Parse(thePointCoords[0]);
                    double y = double.Parse(thePointCoords[1]);
                    double z = double.Parse(thePointCoords[2]);
                    Point3D newPoint = new Point3D(x, y, z);
                }
            }
            return path;
        }
    }
}
