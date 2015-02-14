using System;


namespace Rectangles
{
    class Rectangles
    {
        static void Main()
        {
            double width = 5;
            double height = 5;
            double perimeter = 2 * (width + height);
            double area = width * height;
            Console.WriteLine("The rectangle with width={0} and height={1} has perimeter={2} and area={3}",
                                width, height, perimeter, area);
        }
    }
}
