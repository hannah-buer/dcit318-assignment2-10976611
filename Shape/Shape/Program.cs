using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating instances of Circle and Rectangle
            Circle circle = new Circle(5.0);
            Rectangle rectangle = new Rectangle(4.0, 6.0);

            // Displaying their areas
            Console.WriteLine($"Area of the circle: {circle.GetArea()}");      
            Console.WriteLine($"Area of the rectangle: {rectangle.GetArea()}");

            Console.ReadLine();
        }
    }
}
